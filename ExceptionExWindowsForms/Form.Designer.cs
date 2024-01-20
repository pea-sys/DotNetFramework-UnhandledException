namespace ExceptionExWindowsForms
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiExceptionButton = new System.Windows.Forms.Button();
            this.threadExceptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiExceptionButton
            // 
            this.uiExceptionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.uiExceptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uiExceptionButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.uiExceptionButton.ForeColor = System.Drawing.Color.White;
            this.uiExceptionButton.Location = new System.Drawing.Point(31, 30);
            this.uiExceptionButton.Name = "uiExceptionButton";
            this.uiExceptionButton.Size = new System.Drawing.Size(89, 59);
            this.uiExceptionButton.TabIndex = 0;
            this.uiExceptionButton.Text = "UI Thread Exception";
            this.uiExceptionButton.UseVisualStyleBackColor = false;
            this.uiExceptionButton.Click += new System.EventHandler(this.uiThreadExceptionButton_Click);
            // 
            // threadExceptionButton
            // 
            this.threadExceptionButton.BackColor = System.Drawing.Color.SteelBlue;
            this.threadExceptionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.threadExceptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threadExceptionButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.threadExceptionButton.ForeColor = System.Drawing.Color.White;
            this.threadExceptionButton.Location = new System.Drawing.Point(178, 30);
            this.threadExceptionButton.Name = "threadExceptionButton";
            this.threadExceptionButton.Size = new System.Drawing.Size(89, 59);
            this.threadExceptionButton.TabIndex = 1;
            this.threadExceptionButton.Text = "Thread Exception";
            this.threadExceptionButton.UseVisualStyleBackColor = false;
            this.threadExceptionButton.Click += new System.EventHandler(this.threadExceptionButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 159);
            this.Controls.Add(this.threadExceptionButton);
            this.Controls.Add(this.uiExceptionButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiExceptionButton;
        private System.Windows.Forms.Button threadExceptionButton;
    }
}

