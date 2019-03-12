namespace ClipTextEditor
{
    partial class ToolForm
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
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnSequentialTab = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(3, 3);
            this.btnDistinct.Margin = new System.Windows.Forms.Padding(0);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(180, 60);
            this.btnDistinct.TabIndex = 0;
            this.btnDistinct.Text = "distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnSequentialTab
            // 
            this.btnSequentialTab.Location = new System.Drawing.Point(183, 3);
            this.btnSequentialTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnSequentialTab.Name = "btnSequentialTab";
            this.btnSequentialTab.Size = new System.Drawing.Size(180, 60);
            this.btnSequentialTab.TabIndex = 1;
            this.btnSequentialTab.Text = "sequential[tab]";
            this.btnSequentialTab.UseVisualStyleBackColor = true;
            this.btnSequentialTab.Click += new System.EventHandler(this.btnSequentialTab_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(363, 3);
            this.btnSort.Margin = new System.Windows.Forms.Padding(0);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(180, 60);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDistinct);
            this.flowLayoutPanel1.Controls.Add(this.btnSequentialTab);
            this.flowLayoutPanel1.Controls.Add(this.btnSort);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(761, 78);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(9, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(763, 417);
            this.splitContainer1.SplitterDistance = 80;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtBefore);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtAfter);
            this.splitContainer2.Size = new System.Drawing.Size(761, 327);
            this.splitContainer2.SplitterDistance = 360;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtBefore
            // 
            this.txtBefore.BackColor = System.Drawing.Color.Black;
            this.txtBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBefore.ForeColor = System.Drawing.Color.Lime;
            this.txtBefore.Location = new System.Drawing.Point(0, 0);
            this.txtBefore.Multiline = true;
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.ReadOnly = true;
            this.txtBefore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBefore.Size = new System.Drawing.Size(360, 327);
            this.txtBefore.TabIndex = 0;
            this.txtBefore.WordWrap = false;
            // 
            // txtAfter
            // 
            this.txtAfter.BackColor = System.Drawing.Color.Black;
            this.txtAfter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAfter.ForeColor = System.Drawing.Color.Yellow;
            this.txtAfter.Location = new System.Drawing.Point(0, 0);
            this.txtAfter.Multiline = true;
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.ReadOnly = true;
            this.txtAfter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAfter.Size = new System.Drawing.Size(393, 327);
            this.txtAfter.TabIndex = 1;
            this.txtAfter.WordWrap = false;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Myrica M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToolForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Clipboard Text Editor - β";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnSequentialTab;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
    }
}

