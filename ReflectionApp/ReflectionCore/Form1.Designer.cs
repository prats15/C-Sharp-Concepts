
namespace ReflectionCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lblConstructor = new System.Windows.Forms.Label();
            this.listBoxMethod = new System.Windows.Forms.ListBox();
            this.listBoxProp = new System.Windows.Forms.ListBox();
            this.listBoxConstructor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeName.Location = new System.Drawing.Point(40, 20);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(100, 23);
            this.lblTypeName.TabIndex = 1;
            this.lblTypeName.Text = "Type Name";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(176, 16);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(581, 27);
            this.textBoxType.TabIndex = 2;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGetInfo.Location = new System.Drawing.Point(806, 16);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(94, 29);
            this.btnGetInfo.TabIndex = 3;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMethod.Location = new System.Drawing.Point(70, 81);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(71, 20);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Methods";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProperties.Location = new System.Drawing.Point(443, 81);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(81, 20);
            this.lblProperties.TabIndex = 5;
            this.lblProperties.Text = "Properties";
            // 
            // lblConstructor
            // 
            this.lblConstructor.AutoSize = true;
            this.lblConstructor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConstructor.Location = new System.Drawing.Point(759, 81);
            this.lblConstructor.Name = "lblConstructor";
            this.lblConstructor.Size = new System.Drawing.Size(99, 20);
            this.lblConstructor.TabIndex = 6;
            this.lblConstructor.Text = "Constructors";
            // 
            // listBoxMethod
            // 
            this.listBoxMethod.FormattingEnabled = true;
            this.listBoxMethod.ItemHeight = 20;
            this.listBoxMethod.Location = new System.Drawing.Point(29, 104);
            this.listBoxMethod.Name = "listBoxMethod";
            this.listBoxMethod.Size = new System.Drawing.Size(250, 324);
            this.listBoxMethod.TabIndex = 7;
            // 
            // listBoxProp
            // 
            this.listBoxProp.FormattingEnabled = true;
            this.listBoxProp.ItemHeight = 20;
            this.listBoxProp.Location = new System.Drawing.Point(362, 104);
            this.listBoxProp.Name = "listBoxProp";
            this.listBoxProp.Size = new System.Drawing.Size(271, 324);
            this.listBoxProp.TabIndex = 10;
            // 
            // listBoxConstructor
            // 
            this.listBoxConstructor.FormattingEnabled = true;
            this.listBoxConstructor.ItemHeight = 20;
            this.listBoxConstructor.Location = new System.Drawing.Point(702, 104);
            this.listBoxConstructor.Name = "listBoxConstructor";
            this.listBoxConstructor.Size = new System.Drawing.Size(257, 324);
            this.listBoxConstructor.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 546);
            this.Controls.Add(this.listBoxConstructor);
            this.Controls.Add(this.listBoxProp);
            this.Controls.Add(this.listBoxMethod);
            this.Controls.Add(this.lblConstructor);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Label lblConstructor;
        private System.Windows.Forms.ListBox listBoxMethod;
        private System.Windows.Forms.ListBox listBoxProp;
        private System.Windows.Forms.ListBox listBoxConstructor;
    }
}

