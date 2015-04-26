namespace SunViewProject1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.httpServerLabel = new System.Windows.Forms.Label();
            this.tsHttpServerAtRequestLabel = new System.Windows.Forms.Label();
            this.httpServerRTLabel = new System.Windows.Forms.Label();
            this.tsHttpServerAtResponseLabel = new System.Windows.Forms.Label();
            this.responseTimeHttpServerLabel = new System.Windows.Forms.Label();
            this.tsRequestHttpServerLabel = new System.Windows.Forms.Label();
            this.tsResponseHttpServerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkLogsButton = new System.Windows.Forms.Button();
            this.readDataButton = new System.Windows.Forms.Button();
            this.tsRequestAppServerLabel = new System.Windows.Forms.Label();
            this.tsResponseAppServerLabel = new System.Windows.Forms.Label();
            this.appServerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getRequestTsAppServerAtRequestLabel = new System.Windows.Forms.Label();
            this.getRequestTsRequestAppServerLabel = new System.Windows.Forms.Label();
            this.getRequestTsAppServerAtResponseLabel = new System.Windows.Forms.Label();
            this.getRequestTsResponseAppServerLabel = new System.Windows.Forms.Label();
            this.getRequestReadDataAppServerButton = new System.Windows.Forms.Button();
            this.pingButton = new System.Windows.Forms.Button();
            this.ping1Label = new System.Windows.Forms.Label();
            this.ping2Label = new System.Windows.Forms.Label();
            this.pingLogsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appServerPictureBox = new System.Windows.Forms.PictureBox();
            this.httpServerPictureBox = new System.Windows.Forms.PictureBox();
            this.getRequestResponseTimeAppServerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appServerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpServerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // httpServerLabel
            // 
            this.httpServerLabel.AutoSize = true;
            this.httpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.httpServerLabel.Location = new System.Drawing.Point(13, 13);
            this.httpServerLabel.Name = "httpServerLabel";
            this.httpServerLabel.Size = new System.Drawing.Size(81, 13);
            this.httpServerLabel.TabIndex = 1;
            this.httpServerLabel.Text = "HTTP Server";
            // 
            // tsHttpServerAtRequestLabel
            // 
            this.tsHttpServerAtRequestLabel.AutoSize = true;
            this.tsHttpServerAtRequestLabel.Location = new System.Drawing.Point(13, 255);
            this.tsHttpServerAtRequestLabel.Name = "tsHttpServerAtRequestLabel";
            this.tsHttpServerAtRequestLabel.Size = new System.Drawing.Size(122, 13);
            this.tsHttpServerAtRequestLabel.TabIndex = 3;
            this.tsHttpServerAtRequestLabel.Text = "TimeStamp At Request: ";
            // 
            // httpServerRTLabel
            // 
            this.httpServerRTLabel.AutoSize = true;
            this.httpServerRTLabel.Location = new System.Drawing.Point(13, 206);
            this.httpServerRTLabel.Name = "httpServerRTLabel";
            this.httpServerRTLabel.Size = new System.Drawing.Size(84, 13);
            this.httpServerRTLabel.TabIndex = 4;
            this.httpServerRTLabel.Text = "Response Time:";
            // 
            // tsHttpServerAtResponseLabel
            // 
            this.tsHttpServerAtResponseLabel.AutoSize = true;
            this.tsHttpServerAtResponseLabel.Location = new System.Drawing.Point(13, 305);
            this.tsHttpServerAtResponseLabel.Name = "tsHttpServerAtResponseLabel";
            this.tsHttpServerAtResponseLabel.Size = new System.Drawing.Size(127, 13);
            this.tsHttpServerAtResponseLabel.TabIndex = 5;
            this.tsHttpServerAtResponseLabel.Text = "TimeStamp At Response:";
            // 
            // responseTimeHttpServerLabel
            // 
            this.responseTimeHttpServerLabel.AutoSize = true;
            this.responseTimeHttpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseTimeHttpServerLabel.ForeColor = System.Drawing.Color.Green;
            this.responseTimeHttpServerLabel.Location = new System.Drawing.Point(13, 230);
            this.responseTimeHttpServerLabel.Name = "responseTimeHttpServerLabel";
            this.responseTimeHttpServerLabel.Size = new System.Drawing.Size(0, 13);
            this.responseTimeHttpServerLabel.TabIndex = 6;
            // 
            // tsRequestHttpServerLabel
            // 
            this.tsRequestHttpServerLabel.AutoSize = true;
            this.tsRequestHttpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRequestHttpServerLabel.ForeColor = System.Drawing.Color.Green;
            this.tsRequestHttpServerLabel.Location = new System.Drawing.Point(13, 279);
            this.tsRequestHttpServerLabel.Name = "tsRequestHttpServerLabel";
            this.tsRequestHttpServerLabel.Size = new System.Drawing.Size(0, 13);
            this.tsRequestHttpServerLabel.TabIndex = 7;
            // 
            // tsResponseHttpServerLabel
            // 
            this.tsResponseHttpServerLabel.AutoSize = true;
            this.tsResponseHttpServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsResponseHttpServerLabel.ForeColor = System.Drawing.Color.Green;
            this.tsResponseHttpServerLabel.Location = new System.Drawing.Point(13, 330);
            this.tsResponseHttpServerLabel.Name = "tsResponseHttpServerLabel";
            this.tsResponseHttpServerLabel.Size = new System.Drawing.Size(0, 13);
            this.tsResponseHttpServerLabel.TabIndex = 8;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(164, 443);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit Aplication";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkLogsButton
            // 
            this.checkLogsButton.Location = new System.Drawing.Point(12, 443);
            this.checkLogsButton.Name = "checkLogsButton";
            this.checkLogsButton.Size = new System.Drawing.Size(146, 32);
            this.checkLogsButton.TabIndex = 10;
            this.checkLogsButton.Text = "Check Servers Logs";
            this.checkLogsButton.UseVisualStyleBackColor = true;
            this.checkLogsButton.Click += new System.EventHandler(this.checkLogsButton_Click);
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(12, 364);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(146, 51);
            this.readDataButton.TabIndex = 11;
            this.readDataButton.Text = "HTTP Server Page Source\r\n\r\n(Static HTML Page)";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // tsRequestAppServerLabel
            // 
            this.tsRequestAppServerLabel.AutoSize = true;
            this.tsRequestAppServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsRequestAppServerLabel.ForeColor = System.Drawing.Color.Green;
            this.tsRequestAppServerLabel.Location = new System.Drawing.Point(271, 279);
            this.tsRequestAppServerLabel.Name = "tsRequestAppServerLabel";
            this.tsRequestAppServerLabel.Size = new System.Drawing.Size(0, 13);
            this.tsRequestAppServerLabel.TabIndex = 17;
            // 
            // tsResponseAppServerLabel
            // 
            this.tsResponseAppServerLabel.AutoSize = true;
            this.tsResponseAppServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsResponseAppServerLabel.ForeColor = System.Drawing.Color.Green;
            this.tsResponseAppServerLabel.Location = new System.Drawing.Point(271, 330);
            this.tsResponseAppServerLabel.Name = "tsResponseAppServerLabel";
            this.tsResponseAppServerLabel.Size = new System.Drawing.Size(0, 13);
            this.tsResponseAppServerLabel.TabIndex = 19;
            // 
            // appServerLabel
            // 
            this.appServerLabel.AutoSize = true;
            this.appServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appServerLabel.Location = new System.Drawing.Point(277, 13);
            this.appServerLabel.Name = "appServerLabel";
            this.appServerLabel.Size = new System.Drawing.Size(111, 13);
            this.appServerLabel.TabIndex = 21;
            this.appServerLabel.Text = "Application Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Response Time:";
            // 
            // getRequestTsAppServerAtRequestLabel
            // 
            this.getRequestTsAppServerAtRequestLabel.AutoSize = true;
            this.getRequestTsAppServerAtRequestLabel.Location = new System.Drawing.Point(277, 255);
            this.getRequestTsAppServerAtRequestLabel.Name = "getRequestTsAppServerAtRequestLabel";
            this.getRequestTsAppServerAtRequestLabel.Size = new System.Drawing.Size(119, 13);
            this.getRequestTsAppServerAtRequestLabel.TabIndex = 25;
            this.getRequestTsAppServerAtRequestLabel.Text = "TimeStamp At Request:";
            // 
            // getRequestTsRequestAppServerLabel
            // 
            this.getRequestTsRequestAppServerLabel.AutoSize = true;
            this.getRequestTsRequestAppServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRequestTsRequestAppServerLabel.ForeColor = System.Drawing.Color.Green;
            this.getRequestTsRequestAppServerLabel.Location = new System.Drawing.Point(277, 279);
            this.getRequestTsRequestAppServerLabel.Name = "getRequestTsRequestAppServerLabel";
            this.getRequestTsRequestAppServerLabel.Size = new System.Drawing.Size(0, 13);
            this.getRequestTsRequestAppServerLabel.TabIndex = 26;
            // 
            // getRequestTsAppServerAtResponseLabel
            // 
            this.getRequestTsAppServerAtResponseLabel.AutoSize = true;
            this.getRequestTsAppServerAtResponseLabel.Location = new System.Drawing.Point(277, 305);
            this.getRequestTsAppServerAtResponseLabel.Name = "getRequestTsAppServerAtResponseLabel";
            this.getRequestTsAppServerAtResponseLabel.Size = new System.Drawing.Size(127, 13);
            this.getRequestTsAppServerAtResponseLabel.TabIndex = 27;
            this.getRequestTsAppServerAtResponseLabel.Text = "TimeStamp At Response:";
            // 
            // getRequestTsResponseAppServerLabel
            // 
            this.getRequestTsResponseAppServerLabel.AutoSize = true;
            this.getRequestTsResponseAppServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRequestTsResponseAppServerLabel.ForeColor = System.Drawing.Color.Green;
            this.getRequestTsResponseAppServerLabel.Location = new System.Drawing.Point(277, 330);
            this.getRequestTsResponseAppServerLabel.Name = "getRequestTsResponseAppServerLabel";
            this.getRequestTsResponseAppServerLabel.Size = new System.Drawing.Size(0, 13);
            this.getRequestTsResponseAppServerLabel.TabIndex = 28;
            // 
            // getRequestReadDataAppServerButton
            // 
            this.getRequestReadDataAppServerButton.Location = new System.Drawing.Point(277, 364);
            this.getRequestReadDataAppServerButton.Name = "getRequestReadDataAppServerButton";
            this.getRequestReadDataAppServerButton.Size = new System.Drawing.Size(143, 51);
            this.getRequestReadDataAppServerButton.TabIndex = 29;
            this.getRequestReadDataAppServerButton.Text = "App Server Page Source\r\n(HTML Page Of Get Request)";
            this.getRequestReadDataAppServerButton.UseVisualStyleBackColor = true;
            this.getRequestReadDataAppServerButton.Click += new System.EventHandler(this.getRequestReadDataAppServerButton_Click);
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(12, 152);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(146, 37);
            this.pingButton.TabIndex = 30;
            this.pingButton.Text = "Ping1 - GETStat - GETDyn - Ping2";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // ping1Label
            // 
            this.ping1Label.AutoSize = true;
            this.ping1Label.ForeColor = System.Drawing.Color.Red;
            this.ping1Label.Location = new System.Drawing.Point(274, 153);
            this.ping1Label.Name = "ping1Label";
            this.ping1Label.Size = new System.Drawing.Size(0, 13);
            this.ping1Label.TabIndex = 31;
            // 
            // ping2Label
            // 
            this.ping2Label.AutoSize = true;
            this.ping2Label.ForeColor = System.Drawing.Color.Red;
            this.ping2Label.Location = new System.Drawing.Point(274, 176);
            this.ping2Label.Name = "ping2Label";
            this.ping2Label.Size = new System.Drawing.Size(0, 13);
            this.ping2Label.TabIndex = 32;
            // 
            // pingLogsButton
            // 
            this.pingLogsButton.Location = new System.Drawing.Point(277, 443);
            this.pingLogsButton.Name = "pingLogsButton";
            this.pingLogsButton.Size = new System.Drawing.Size(143, 32);
            this.pingLogsButton.TabIndex = 33;
            this.pingLogsButton.Text = "Check Ping Logs";
            this.pingLogsButton.UseVisualStyleBackColor = true;
            this.pingLogsButton.Click += new System.EventHandler(this.pingLogsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SunViewProject1.Properties.Resources.changegear9;
            this.pictureBox1.Location = new System.Drawing.Point(127, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // appServerPictureBox
            // 
            this.appServerPictureBox.Image = global::SunViewProject1.Properties.Resources.tomcat;
            this.appServerPictureBox.Location = new System.Drawing.Point(277, 39);
            this.appServerPictureBox.Name = "appServerPictureBox";
            this.appServerPictureBox.Size = new System.Drawing.Size(146, 95);
            this.appServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appServerPictureBox.TabIndex = 13;
            this.appServerPictureBox.TabStop = false;
            // 
            // httpServerPictureBox
            // 
            this.httpServerPictureBox.Image = global::SunViewProject1.Properties.Resources.server;
            this.httpServerPictureBox.Location = new System.Drawing.Point(12, 39);
            this.httpServerPictureBox.Name = "httpServerPictureBox";
            this.httpServerPictureBox.Size = new System.Drawing.Size(146, 95);
            this.httpServerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.httpServerPictureBox.TabIndex = 0;
            this.httpServerPictureBox.TabStop = false;
            // 
            // getRequestResponseTimeAppServerLabel
            // 
            this.getRequestResponseTimeAppServerLabel.AutoSize = true;
            this.getRequestResponseTimeAppServerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRequestResponseTimeAppServerLabel.ForeColor = System.Drawing.Color.Green;
            this.getRequestResponseTimeAppServerLabel.Location = new System.Drawing.Point(277, 230);
            this.getRequestResponseTimeAppServerLabel.Name = "getRequestResponseTimeAppServerLabel";
            this.getRequestResponseTimeAppServerLabel.Size = new System.Drawing.Size(0, 13);
            this.getRequestResponseTimeAppServerLabel.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 553);
            this.Controls.Add(this.getRequestResponseTimeAppServerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pingLogsButton);
            this.Controls.Add(this.ping2Label);
            this.Controls.Add(this.ping1Label);
            this.Controls.Add(this.pingButton);
            this.Controls.Add(this.getRequestReadDataAppServerButton);
            this.Controls.Add(this.getRequestTsResponseAppServerLabel);
            this.Controls.Add(this.getRequestTsAppServerAtResponseLabel);
            this.Controls.Add(this.getRequestTsRequestAppServerLabel);
            this.Controls.Add(this.getRequestTsAppServerAtRequestLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appServerLabel);
            this.Controls.Add(this.tsResponseAppServerLabel);
            this.Controls.Add(this.tsRequestAppServerLabel);
            this.Controls.Add(this.appServerPictureBox);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.checkLogsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tsResponseHttpServerLabel);
            this.Controls.Add(this.tsRequestHttpServerLabel);
            this.Controls.Add(this.responseTimeHttpServerLabel);
            this.Controls.Add(this.tsHttpServerAtResponseLabel);
            this.Controls.Add(this.httpServerRTLabel);
            this.Controls.Add(this.tsHttpServerAtRequestLabel);
            this.Controls.Add(this.httpServerLabel);
            this.Controls.Add(this.httpServerPictureBox);
            this.Name = "Form1";
            this.Text = "User Experience Monitoring Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appServerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.httpServerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox httpServerPictureBox;
        private System.Windows.Forms.Label httpServerLabel;
        private System.Windows.Forms.Label tsHttpServerAtRequestLabel;
        private System.Windows.Forms.Label httpServerRTLabel;
        private System.Windows.Forms.Label tsHttpServerAtResponseLabel;
        private System.Windows.Forms.Label responseTimeHttpServerLabel;
        private System.Windows.Forms.Label tsRequestHttpServerLabel;
        private System.Windows.Forms.Label tsResponseHttpServerLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkLogsButton;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.PictureBox appServerPictureBox;
        private System.Windows.Forms.Label tsRequestAppServerLabel;
        private System.Windows.Forms.Label tsResponseAppServerLabel;
        private System.Windows.Forms.Label appServerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label getRequestTsAppServerAtRequestLabel;
        private System.Windows.Forms.Label getRequestTsRequestAppServerLabel;
        private System.Windows.Forms.Label getRequestTsAppServerAtResponseLabel;
        private System.Windows.Forms.Label getRequestTsResponseAppServerLabel;
        private System.Windows.Forms.Button getRequestReadDataAppServerButton;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Label ping1Label;
        private System.Windows.Forms.Label ping2Label;
        private System.Windows.Forms.Button pingLogsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label getRequestResponseTimeAppServerLabel;
    }
}

