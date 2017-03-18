namespace badboy_prohibitor
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.steam = new System.Windows.Forms.CheckBox();
            this.CheckBox6 = new System.Windows.Forms.CheckBox();
            this.mcbox = new System.Windows.Forms.CheckBox();
            this.mc = new System.Windows.Forms.CheckBox();
            this._7k7k = new System.Windows.Forms.CheckBox();
            this._3366 = new System.Windows.Forms.CheckBox();
            this._4399 = new System.Windows.Forms.CheckBox();
            this.dnf = new System.Windows.Forms.CheckBox();
            this.x5 = new System.Windows.Forms.CheckBox();
            this.speed = new System.Windows.Forms.CheckBox();
            this.crossfire = new System.Windows.Forms.CheckBox();
            this.lol = new System.Windows.Forms.CheckBox();
            this.tgp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.steam);
            this.groupBox1.Controls.Add(this.CheckBox6);
            this.groupBox1.Controls.Add(this.mcbox);
            this.groupBox1.Controls.Add(this.mc);
            this.groupBox1.Controls.Add(this._7k7k);
            this.groupBox1.Controls.Add(this._3366);
            this.groupBox1.Controls.Add(this._4399);
            this.groupBox1.Controls.Add(this.dnf);
            this.groupBox1.Controls.Add(this.x5);
            this.groupBox1.Controls.Add(this.speed);
            this.groupBox1.Controls.Add(this.crossfire);
            this.groupBox1.Controls.Add(this.lol);
            this.groupBox1.Controls.Add(this.tgp);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "游戏/软件/网络管理";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "自定义规则";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // steam
            // 
            this.steam.AutoSize = true;
            this.steam.Location = new System.Drawing.Point(6, 281);
            this.steam.Name = "steam";
            this.steam.Size = new System.Drawing.Size(137, 25);
            this.steam.TabIndex = 12;
            this.steam.Text = "禁止steam运行";
            this.steam.UseVisualStyleBackColor = true;
            // 
            // CheckBox6
            // 
            this.CheckBox6.AutoSize = true;
            this.CheckBox6.Location = new System.Drawing.Point(192, 398);
            this.CheckBox6.Name = "CheckBox6";
            this.CheckBox6.Size = new System.Drawing.Size(61, 25);
            this.CheckBox6.TabIndex = 11;
            this.CheckBox6.Text = "全选";
            this.CheckBox6.UseVisualStyleBackColor = true;
            this.CheckBox6.CheckedChanged += new System.EventHandler(this.CheckBox6_CheckedChanged);
            // 
            // mcbox
            // 
            this.mcbox.AutoSize = true;
            this.mcbox.Location = new System.Drawing.Point(6, 250);
            this.mcbox.Name = "mcbox";
            this.mcbox.Size = new System.Drawing.Size(157, 25);
            this.mcbox.TabIndex = 10;
            this.mcbox.Text = "禁止炸妈盒子运行";
            this.mcbox.UseVisualStyleBackColor = true;
            // 
            // mc
            // 
            this.mc.AutoSize = true;
            this.mc.Location = new System.Drawing.Point(6, 219);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(157, 25);
            this.mc.TabIndex = 9;
            this.mc.Text = "禁止我的世界运行";
            this.mc.UseVisualStyleBackColor = true;
            // 
            // _7k7k
            // 
            this._7k7k.AutoSize = true;
            this._7k7k.Location = new System.Drawing.Point(6, 374);
            this._7k7k.Name = "_7k7k";
            this._7k7k.Size = new System.Drawing.Size(127, 25);
            this._7k7k.TabIndex = 8;
            this._7k7k.Text = "禁止访问7k7k";
            this._7k7k.UseVisualStyleBackColor = true;
            this._7k7k.CheckedChanged += new System.EventHandler(this._7k7k_CheckedChanged);
            // 
            // _3366
            // 
            this._3366.AutoSize = true;
            this._3366.Location = new System.Drawing.Point(6, 343);
            this._3366.Name = "_3366";
            this._3366.Size = new System.Drawing.Size(129, 25);
            this._3366.TabIndex = 7;
            this._3366.Text = "禁止访问3366";
            this._3366.UseVisualStyleBackColor = true;
            this._3366.CheckedChanged += new System.EventHandler(this._3366_CheckedChanged);
            // 
            // _4399
            // 
            this._4399.AutoSize = true;
            this._4399.Location = new System.Drawing.Point(6, 312);
            this._4399.Name = "_4399";
            this._4399.Size = new System.Drawing.Size(129, 25);
            this._4399.TabIndex = 6;
            this._4399.Text = "禁止访问4399";
            this._4399.UseVisualStyleBackColor = true;
            this._4399.CheckedChanged += new System.EventHandler(this._4399_CheckedChanged);
            // 
            // dnf
            // 
            this.dnf.AutoSize = true;
            this.dnf.Location = new System.Drawing.Point(6, 187);
            this.dnf.Name = "dnf";
            this.dnf.Size = new System.Drawing.Size(189, 25);
            this.dnf.TabIndex = 5;
            this.dnf.Text = "禁止地下城与勇士运行";
            this.dnf.UseVisualStyleBackColor = true;
            // 
            // x5
            // 
            this.x5.AutoSize = true;
            this.x5.Location = new System.Drawing.Point(6, 156);
            this.x5.Name = "x5";
            this.x5.Size = new System.Drawing.Size(151, 25);
            this.x5.TabIndex = 4;
            this.x5.Text = "禁止QQ炫舞运行";
            this.x5.UseVisualStyleBackColor = true;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(6, 123);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(151, 25);
            this.speed.TabIndex = 3;
            this.speed.Text = "禁止QQ飞车运行";
            this.speed.UseVisualStyleBackColor = true;
            // 
            // crossfire
            // 
            this.crossfire.AutoSize = true;
            this.crossfire.Location = new System.Drawing.Point(6, 92);
            this.crossfire.Name = "crossfire";
            this.crossfire.Size = new System.Drawing.Size(157, 25);
            this.crossfire.TabIndex = 2;
            this.crossfire.Text = "禁止穿越火线运行";
            this.crossfire.UseVisualStyleBackColor = true;
            // 
            // lol
            // 
            this.lol.AutoSize = true;
            this.lol.Location = new System.Drawing.Point(6, 61);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(157, 25);
            this.lol.TabIndex = 1;
            this.lol.Text = "禁止英雄联盟运行";
            this.lol.UseVisualStyleBackColor = true;
            // 
            // tgp
            // 
            this.tgp.AutoSize = true;
            this.tgp.Location = new System.Drawing.Point(6, 28);
            this.tgp.Name = "tgp";
            this.tgp.Size = new System.Drawing.Size(123, 25);
            this.tgp.TabIndex = 0;
            this.tgp.Text = "禁止TGP运行";
            this.tgp.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 506);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "badboyprohibitor V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tgp;
        private System.Windows.Forms.CheckBox speed;
        private System.Windows.Forms.CheckBox crossfire;
        private System.Windows.Forms.CheckBox lol;
        private System.Windows.Forms.CheckBox x5;
        private System.Windows.Forms.CheckBox dnf;
        private System.Windows.Forms.CheckBox _7k7k;
        private System.Windows.Forms.CheckBox _3366;
        private System.Windows.Forms.CheckBox _4399;
        private System.Windows.Forms.CheckBox CheckBox6;
        private System.Windows.Forms.CheckBox mcbox;
        private System.Windows.Forms.CheckBox mc;
        private System.Windows.Forms.CheckBox steam;
        private System.Windows.Forms.Button button1;
    }
}

