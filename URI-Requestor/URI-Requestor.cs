using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URIRequestor
{
	public partial class URIRequestor : Form
	{
		CancellationTokenSource tokenSource = new CancellationTokenSource();

		List<URIItem> listOfURIs = new List<URIItem>();


		public URIRequestor()
		{
			InitializeComponent();
		}

		private void AddToListBoxButton_Click(object sender, EventArgs e)
		{
			string input = AddToURIListBoxTextBox.Text;

			if (input.Length < 3)
				return;


			if (Uri.IsWellFormedUriString(input, UriKind.Absolute))
			{
				Uri convertedInput = new Uri(input);
				URIItem item = new URIItem(convertedInput);

				listOfURIs.Add(item);
				URIListBox.Items.Add(input);
			}
			else
				ConvertInputLabelToError();

			AddToURIListBoxTextBox.Clear();
		}

		private void RemoveFromURIListButton_Click(object sender, EventArgs e)
		{
			List<int> indexList = new List<int>();
			for (int i = 0; i < URIListBox.SelectedItems.Count; i++)
				indexList.Add(URIListBox.Items.IndexOf(URIListBox.SelectedItems[i]));

			foreach (int index in Enumerable.Reverse(indexList))
			{
				URIListBox.Items.RemoveAt(index);
				listOfURIs.RemoveAt(index);
			}
		}

		private async void RequestButton_Click(object sender, EventArgs e)
		{
			// Disable everything so we know we're running.
			ToggleOnRequest(false);

			CancellationToken cancelToken = tokenSource.Token;
			List<Task<string>> tasks = new List<Task<string>>();
			List<string> results = new List<string>();

			for (int i = 0; i < listOfURIs.Count; i++)
				tasks.Add(RequestItem(listOfURIs[i], cancelToken));

			await Task.WhenAll(tasks.ToArray());

			for (int i = 0; i < tasks.Count; i++)
				results.Add(tasks[i].Result);

			ResultsListBox.Items.AddRange(results.ToArray());

			// Enable everything again, so we know we either succeeded or cancelled
			ToggleOnRequest(true);
		}

		private void AbortButton_Click(object sender, EventArgs e)
		{
			tokenSource.Cancel();
			tokenSource = new CancellationTokenSource();
		}

		private void AddToURIListBoxTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddURITextLabel.ForeColor == Color.Red)
			{
				AddURITextLabel.Font = new Font(DefaultFont, FontStyle.Regular);
				AddURITextLabel.ForeColor = DefaultForeColor;
				AddURITextLabel.Text = "Enter URI to queue:";
			}
		}


		private void ToggleOnRequest(bool toggle)
		{
			RequestButton.Enabled = toggle;
			AddToURIListBoxButton.Enabled = toggle;
			RemoveFromURIListButton.Enabled = toggle;
		}

		private void ConvertInputLabelToError()
		{
			AddURITextLabel.Font = new Font(DefaultFont, FontStyle.Bold);
			AddURITextLabel.ForeColor = Color.Red;
			AddURITextLabel.Text = "This is not a vlaid URI; please try again:";
		}

		private static Task<string> RequestItem(URIItem item, CancellationToken cancelToken)
		{
			cancelToken.ThrowIfCancellationRequested();
			return Task.Run(() =>
			{
				// Create a new WebRequest Object to the mentioned URL.
				WebRequest req = WebRequest.Create(item.URI);

				// Assign the response object of 'WebRequest' to a 'WebResponse' variable.
				// And get the stream containing content returned by the server.
				try
				{
					using (WebResponse resp = req.GetResponse())
					using (Stream streamResp = resp.GetResponseStream())
					using (StreamReader reader = new StreamReader(streamResp))
						// Read and return
						return reader.ReadToEnd();
				}
				catch (Exception e)
				{
					if (e is OperationCanceledException)
						return "Operation cancelled.";
					else
						return e.Message;
				}
			});
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string clipboardText = "";
			foreach (string item in ResultsListBox.SelectedItems)
				clipboardText += item + "\r\n";
			
			Clipboard.SetText(clipboardText.Trim());
		}
	}
}