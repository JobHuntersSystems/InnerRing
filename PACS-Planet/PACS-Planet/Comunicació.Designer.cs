
namespace PACS_Planet
{
	partial class Comunicació
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstComunication = new System.Windows.Forms.ListBox();
			this.plServer = new System.Windows.Forms.Panel();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.plStatus = new System.Windows.Forms.Panel();
			this.lblResult = new System.Windows.Forms.Label();
			this.lblLastMessage = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.txtLastMessage = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.plServer.SuspendLayout();
			this.plStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstComunication
			// 
			this.lstComunication.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lstComunication.ForeColor = System.Drawing.SystemColors.Window;
			this.lstComunication.FormattingEnabled = true;
			this.lstComunication.ItemHeight = 16;
			this.lstComunication.Location = new System.Drawing.Point(12, 70);
			this.lstComunication.Name = "lstComunication";
			this.lstComunication.Size = new System.Drawing.Size(775, 276);
			this.lstComunication.TabIndex = 0;
			// 
			// plServer
			// 
			this.plServer.Controls.Add(this.txtServer);
			this.plServer.Controls.Add(this.lblServer);
			this.plServer.Controls.Add(this.btnStop);
			this.plServer.Controls.Add(this.btnStart);
			this.plServer.Location = new System.Drawing.Point(12, 13);
			this.plServer.Name = "plServer";
			this.plServer.Size = new System.Drawing.Size(385, 51);
			this.plServer.TabIndex = 1;
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(264, 19);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(100, 22);
			this.txtServer.TabIndex = 3;
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Location = new System.Drawing.Point(204, 19);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(54, 17);
			this.lblServer.TabIndex = 2;
			this.lblServer.Text = "Server:";
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(111, 16);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(20, 17);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			// 
			// plStatus
			// 
			this.plStatus.Controls.Add(this.txtResult);
			this.plStatus.Controls.Add(this.txtLastMessage);
			this.plStatus.Controls.Add(this.txtStatus);
			this.plStatus.Controls.Add(this.lblResult);
			this.plStatus.Controls.Add(this.lblLastMessage);
			this.plStatus.Controls.Add(this.lblStatus);
			this.plStatus.Location = new System.Drawing.Point(13, 352);
			this.plStatus.Name = "plStatus";
			this.plStatus.Size = new System.Drawing.Size(384, 94);
			this.plStatus.TabIndex = 2;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(55, 72);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(52, 17);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "Result:";
			// 
			// lblLastMessage
			// 
			this.lblLastMessage.AutoSize = true;
			this.lblLastMessage.Location = new System.Drawing.Point(8, 37);
			this.lblLastMessage.Name = "lblLastMessage";
			this.lblLastMessage.Size = new System.Drawing.Size(100, 17);
			this.lblLastMessage.TabIndex = 1;
			this.lblLastMessage.Text = "Last Message:";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(55, 9);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(52, 17);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Status:";
			// 
			// txtStatus
			// 
			this.txtStatus.Location = new System.Drawing.Point(114, 9);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(100, 22);
			this.txtStatus.TabIndex = 3;
			// 
			// txtLastMessage
			// 
			this.txtLastMessage.Location = new System.Drawing.Point(114, 37);
			this.txtLastMessage.Name = "txtLastMessage";
			this.txtLastMessage.Size = new System.Drawing.Size(249, 22);
			this.txtLastMessage.TabIndex = 4;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(114, 69);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(100, 22);
			this.txtResult.TabIndex = 5;
			// 
			// Comunicació
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.plStatus);
			this.Controls.Add(this.plServer);
			this.Controls.Add(this.lstComunication);
			this.Name = "Comunicació";
			this.Text = "Comunicació amb naus";
			this.plServer.ResumeLayout(false);
			this.plServer.PerformLayout();
			this.plStatus.ResumeLayout(false);
			this.plStatus.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstComunication;
		private System.Windows.Forms.Panel plServer;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Panel plStatus;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label lblLastMessage;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.TextBox txtLastMessage;
		private System.Windows.Forms.TextBox txtStatus;
	}
}

