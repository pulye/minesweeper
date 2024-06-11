namespace minesweeper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip;
        private ToolStripMenuItem jocToolStripMenuItem;
        private ToolStripMenuItem nouToolStripMenuItem;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            etichetaCronometru = new Label();
            menuStrip = new MenuStrip();
            jocToolStripMenuItem = new ToolStripMenuItem();
            nouToolStripMenuItem = new ToolStripMenuItem();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel = new TableLayoutPanel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // etichetaCronometru
            // 
            etichetaCronometru.Dock = DockStyle.Top;
            etichetaCronometru.Font = new Font("Tahoma", 12, FontStyle.Bold);
            etichetaCronometru.Location = new Point(0, 0);
            etichetaCronometru.Name = "etichetaCronometru";
            etichetaCronometru.Size = new Size(400, 24);
            etichetaCronometru.TabIndex = 2;
            etichetaCronometru.Text = "Timp: 0";
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { jocToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(400, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // jocToolStripMenuItem
            // 
            jocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouToolStripMenuItem, iesireToolStripMenuItem });
            jocToolStripMenuItem.Name = "jocToolStripMenuItem";
            jocToolStripMenuItem.Size = new Size(36, 20);
            jocToolStripMenuItem.Text = "Joc";
            // 
            // nouToolStripMenuItem
            // 
            nouToolStripMenuItem.Name = "nouToolStripMenuItem";
            nouToolStripMenuItem.Size = new Size(94, 22);
            nouToolStripMenuItem.Text = "Nou";
            nouToolStripMenuItem.Click += NouToolStripMenuItem_Click;
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(94, 22);
            iesireToolStripMenuItem.Text = "Ieșire";
            iesireToolStripMenuItem.Click += IesireToolStripMenuItem_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 10;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 24);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 10;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Size = new Size(400, 426);
            tableLayoutPanel.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(400, 450);
            Controls.Add(tableLayoutPanel);
            Controls.Add(menuStrip);
            Controls.Add(etichetaCronometru);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Minesweeper";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void IesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
