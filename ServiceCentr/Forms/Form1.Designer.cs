
namespace ServiceCentr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSklad = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnKlietn = new System.Windows.Forms.Button();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.IbITitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnSklad);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.btnKlietn);
            this.panelMenu.Controls.Add(this.btnZakaz);
            this.panelMenu.Controls.Add(this.panelLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 559);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = global::ServiceCentr.Properties.Resources.free_icon_gear_6440453;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 400);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 80);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "  Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSklad
            // 
            this.btnSklad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSklad.FlatAppearance.BorderSize = 0;
            this.btnSklad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSklad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSklad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSklad.Image = global::ServiceCentr.Properties.Resources.premium_icon_warehouse_2066573;
            this.btnSklad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSklad.Location = new System.Drawing.Point(0, 320);
            this.btnSklad.Name = "btnSklad";
            this.btnSklad.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSklad.Size = new System.Drawing.Size(220, 80);
            this.btnSklad.TabIndex = 4;
            this.btnSklad.Text = "  Склад";
            this.btnSklad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSklad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSklad.UseVisualStyleBackColor = true;
            this.btnSklad.Click += new System.EventHandler(this.btnSklad_Click);
            // 
            // btnShop
            // 
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShop.Image = global::ServiceCentr.Properties.Resources.free_icon_shop_126122;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(0, 240);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnShop.Size = new System.Drawing.Size(220, 80);
            this.btnShop.TabIndex = 3;
            this.btnShop.Text = "  Магазин";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnKlietn
            // 
            this.btnKlietn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKlietn.FlatAppearance.BorderSize = 0;
            this.btnKlietn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlietn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKlietn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKlietn.Image = global::ServiceCentr.Properties.Resources.free_icon_client_5969470;
            this.btnKlietn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlietn.Location = new System.Drawing.Point(0, 160);
            this.btnKlietn.Name = "btnKlietn";
            this.btnKlietn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnKlietn.Size = new System.Drawing.Size(220, 80);
            this.btnKlietn.TabIndex = 2;
            this.btnKlietn.Text = "  Клиенты";
            this.btnKlietn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKlietn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKlietn.UseVisualStyleBackColor = true;
            this.btnKlietn.Click += new System.EventHandler(this.btnKlietn_Click);
            // 
            // btnZakaz
            // 
            this.btnZakaz.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnZakaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZakaz.FlatAppearance.BorderSize = 0;
            this.btnZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZakaz.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnZakaz.Image = global::ServiceCentr.Properties.Resources.premium_icon_order_5166133;
            this.btnZakaz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakaz.Location = new System.Drawing.Point(0, 80);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnZakaz.Size = new System.Drawing.Size(220, 80);
            this.btnZakaz.TabIndex = 1;
            this.btnZakaz.Text = "  Заказы";
            this.btnZakaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZakaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZakaz.UseVisualStyleBackColor = false;
            this.btnZakaz.Click += new System.EventHandler(this.btnZakaz_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(220, 80);
            this.panelLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сервисный центр";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelTitleBar.Controls.Add(this.IbITitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1051, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // IbITitle
            // 
            this.IbITitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IbITitle.AutoSize = true;
            this.IbITitle.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IbITitle.ForeColor = System.Drawing.Color.White;
            this.IbITitle.Location = new System.Drawing.Point(465, 25);
            this.IbITitle.Name = "IbITitle";
            this.IbITitle.Size = new System.Drawing.Size(128, 28);
            this.IbITitle.TabIndex = 0;
            this.IbITitle.Text = "ГЛАВНАЯ";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1051, 479);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1271, 559);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSklad;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnKlietn;
        private System.Windows.Forms.Button btnZakaz;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label IbITitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

