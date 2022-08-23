namespace DotNetLearn.windosform
{
    partial class NextForm
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
            this.next_form = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next_form
            // 
            this.next_form.AutoSize = true;
            this.next_form.Location = new System.Drawing.Point(363, 13);
            this.next_form.Name = "next_form";
            this.next_form.Size = new System.Drawing.Size(72, 17);
            this.next_form.TabIndex = 0;
            this.next_form.Text = "Next Form";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three"});
            this.listBox2.Location = new System.Drawing.Point(55, 143);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 84);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // combo_box
            // 
            this.combo_box.FormattingEnabled = true;
            this.combo_box.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday"});
            this.combo_box.Location = new System.Drawing.Point(55, 81);
            this.combo_box.Name = "combo_box";
            this.combo_box.Size = new System.Drawing.Size(121, 24);
            this.combo_box.TabIndex = 3;
            this.combo_box.Text = "Select Day";
            this.combo_box.SelectedIndexChanged += new System.EventHandler(this.combo_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Combo Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "List";
            // 
            // NextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.next_form);
            this.Name = "NextForm";
            this.Text = "NextForm";
            this.Load += new System.EventHandler(this.NextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label next_form;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}