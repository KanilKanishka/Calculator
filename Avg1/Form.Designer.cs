namespace Avg1
{
    partial class average
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
            this.components = new System.ComponentModel.Container();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtsub01 = new System.Windows.Forms.TextBox();
            this.txtsub02 = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblsub01 = new System.Windows.Forms.Label();
            this.lblsub02 = new System.Windows.Forms.Label();
            this.lblsub03 = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(199, 157);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(172, 60);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtsub01
            // 
            this.txtsub01.Location = new System.Drawing.Point(196, 24);
            this.txtsub01.Name = "txtsub01";
            this.txtsub01.Size = new System.Drawing.Size(172, 20);
            this.txtsub01.TabIndex = 1;
            this.txtsub01.Text = "0";
            this.txtsub01.Validating += new System.ComponentModel.CancelEventHandler(this.txtsub01_Validating);
            // 
            // txtsub02
            // 
            this.txtsub02.Location = new System.Drawing.Point(196, 71);
            this.txtsub02.Name = "txtsub02";
            this.txtsub02.Size = new System.Drawing.Size(172, 20);
            this.txtsub02.TabIndex = 2;
            this.txtsub02.Text = "0";
            this.txtsub02.Validating += new System.ComponentModel.CancelEventHandler(this.txtsub02_Validating);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(196, 120);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(172, 20);
            this.txtAverage.TabIndex = 3;
            this.txtAverage.Text = "0";
            this.txtAverage.Validating += new System.ComponentModel.CancelEventHandler(this.txtAverage_Validating);
            // 
            // lblsub01
            // 
            this.lblsub01.AutoSize = true;
            this.lblsub01.Location = new System.Drawing.Point(22, 31);
            this.lblsub01.Name = "lblsub01";
            this.lblsub01.Size = new System.Drawing.Size(52, 13);
            this.lblsub01.TabIndex = 4;
            this.lblsub01.Text = "Subject 1";
            // 
            // lblsub02
            // 
            this.lblsub02.AutoSize = true;
            this.lblsub02.Location = new System.Drawing.Point(22, 78);
            this.lblsub02.Name = "lblsub02";
            this.lblsub02.Size = new System.Drawing.Size(52, 13);
            this.lblsub02.TabIndex = 5;
            this.lblsub02.Text = "Subject 2";
            // 
            // lblsub03
            // 
            this.lblsub03.AutoSize = true;
            this.lblsub03.Location = new System.Drawing.Point(22, 127);
            this.lblsub03.Name = "lblsub03";
            this.lblsub03.Size = new System.Drawing.Size(47, 13);
            this.lblsub03.TabIndex = 6;
            this.lblsub03.Text = "Average";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(399, 204);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(0, 13);
            this.lblaverage.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // average
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 312);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.lblsub03);
            this.Controls.Add(this.lblsub02);
            this.Controls.Add(this.lblsub01);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtsub02);
            this.Controls.Add(this.txtsub01);
            this.Controls.Add(this.btnsubmit);
            this.Name = "average";
            this.Text = "Aggregate function- Average";
            this.Load += new System.EventHandler(this.average_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtsub01;
        private System.Windows.Forms.TextBox txtsub02;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblsub01;
        private System.Windows.Forms.Label lblsub02;
        private System.Windows.Forms.Label lblsub03;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

