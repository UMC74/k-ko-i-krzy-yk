namespace TicTacToe
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.topLeft = new System.Windows.Forms.Button();
            this.topCenter = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.centerLeft = new System.Windows.Forms.Button();
            this.centerCenter = new System.Windows.Forms.Button();
            this.centerRight = new System.Windows.Forms.Button();
            this.bottomLeft = new System.Windows.Forms.Button();
            this.bottomCenter = new System.Windows.Forms.Button();
            this.bottomRight = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.topLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.topCenter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.topRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.centerLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.centerCenter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.centerRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bottomLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomCenter, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomRight, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // topLeft
            // 
            this.topLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.topLeft.Location = new System.Drawing.Point(19, 19);
            this.topLeft.Name = "topLeft";
            this.topLeft.Size = new System.Drawing.Size(128, 120);
            this.topLeft.TabIndex = 0;
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.ButtonClick);
            // 
            // topCenter
            // 
            this.topCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.topCenter.Location = new System.Drawing.Point(153, 19);
            this.topCenter.Name = "topCenter";
            this.topCenter.Size = new System.Drawing.Size(128, 120);
            this.topCenter.TabIndex = 1;
            this.topCenter.UseVisualStyleBackColor = true;
            this.topCenter.Click += new System.EventHandler(this.ButtonClick);
            // 
            // topRight
            // 
            this.topRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.topRight.Location = new System.Drawing.Point(287, 19);
            this.topRight.Name = "topRight";
            this.topRight.Size = new System.Drawing.Size(128, 120);
            this.topRight.TabIndex = 2;
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // centerLeft
            // 
            this.centerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.centerLeft.Location = new System.Drawing.Point(19, 145);
            this.centerLeft.Name = "centerLeft";
            this.centerLeft.Size = new System.Drawing.Size(128, 120);
            this.centerLeft.TabIndex = 3;
            this.centerLeft.UseVisualStyleBackColor = true;
            this.centerLeft.Click += new System.EventHandler(this.ButtonClick);
            // 
            // centerCenter
            // 
            this.centerCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.centerCenter.Location = new System.Drawing.Point(153, 145);
            this.centerCenter.Name = "centerCenter";
            this.centerCenter.Size = new System.Drawing.Size(128, 120);
            this.centerCenter.TabIndex = 4;
            this.centerCenter.UseVisualStyleBackColor = true;
            this.centerCenter.Click += new System.EventHandler(this.ButtonClick);
            // 
            // centerRight
            // 
            this.centerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.centerRight.Location = new System.Drawing.Point(287, 145);
            this.centerRight.Name = "centerRight";
            this.centerRight.Size = new System.Drawing.Size(128, 120);
            this.centerRight.TabIndex = 5;
            this.centerRight.UseVisualStyleBackColor = true;
            this.centerRight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // bottomLeft
            // 
            this.bottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bottomLeft.Location = new System.Drawing.Point(19, 271);
            this.bottomLeft.Name = "bottomLeft";
            this.bottomLeft.Size = new System.Drawing.Size(128, 121);
            this.bottomLeft.TabIndex = 6;
            this.bottomLeft.UseVisualStyleBackColor = true;
            this.bottomLeft.Click += new System.EventHandler(this.ButtonClick);
            // 
            // bottomCenter
            // 
            this.bottomCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bottomCenter.Location = new System.Drawing.Point(153, 271);
            this.bottomCenter.Name = "bottomCenter";
            this.bottomCenter.Size = new System.Drawing.Size(128, 121);
            this.bottomCenter.TabIndex = 7;
            this.bottomCenter.UseVisualStyleBackColor = true;
            this.bottomCenter.Click += new System.EventHandler(this.ButtonClick);
            // 
            // bottomRight
            // 
            this.bottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bottomRight.Location = new System.Drawing.Point(287, 271);
            this.bottomRight.Name = "bottomRight";
            this.bottomRight.Size = new System.Drawing.Size(128, 121);
            this.bottomRight.TabIndex = 8;
            this.bottomRight.UseVisualStyleBackColor = true;
            this.bottomRight.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bottomRight;

        private System.Windows.Forms.Button bottomCenter;

        private System.Windows.Forms.Button bottomLeft;

        private System.Windows.Forms.Button centerRight;

        private System.Windows.Forms.Button centerCenter;

        private System.Windows.Forms.Button centerLeft;

        private System.Windows.Forms.Button topRight;

        private System.Windows.Forms.Button topCenter;

        private System.Windows.Forms.Button topLeft;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}