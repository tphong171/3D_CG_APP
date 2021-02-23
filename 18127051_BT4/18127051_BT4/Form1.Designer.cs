namespace _18127051_BT4
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.cube = new System.Windows.Forms.Button();
            this.pyramid = new System.Windows.Forms.Button();
            this.prism = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.posx = new System.Windows.Forms.TextBox();
            this.posy = new System.Windows.Forms.TextBox();
            this.posz = new System.Windows.Forms.TextBox();
            this.scalez = new System.Windows.Forms.TextBox();
            this.scaley = new System.Windows.Forms.TextBox();
            this.scalex = new System.Windows.Forms.TextBox();
            this.rotatez = new System.Windows.Forms.TextBox();
            this.rotatey = new System.Windows.Forms.TextBox();
            this.rotatex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openexplorer = new System.Windows.Forms.Button();
            this.applytexture = new System.Windows.Forms.Button();
            this.canceltexture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.objectlist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorpicker = new System.Windows.Forms.ColorDialog();
            this.color = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lby = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cury = new System.Windows.Forms.Label();
            this.curx = new System.Windows.Forms.Label();
            this.curz = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.showgrid = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.canmovecam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(2, 2);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1170, 608);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // cube
            // 
            this.cube.Location = new System.Drawing.Point(17, 714);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(84, 46);
            this.cube.TabIndex = 1;
            this.cube.Text = "Cube";
            this.cube.UseVisualStyleBackColor = true;
            this.cube.Click += new System.EventHandler(this.button1_Click);
            // 
            // pyramid
            // 
            this.pyramid.Location = new System.Drawing.Point(122, 714);
            this.pyramid.Name = "pyramid";
            this.pyramid.Size = new System.Drawing.Size(84, 46);
            this.pyramid.TabIndex = 2;
            this.pyramid.Text = "Pyramid";
            this.pyramid.UseVisualStyleBackColor = true;
            this.pyramid.Click += new System.EventHandler(this.pyramid_Click);
            // 
            // prism
            // 
            this.prism.Location = new System.Drawing.Point(226, 714);
            this.prism.Name = "prism";
            this.prism.Size = new System.Drawing.Size(84, 46);
            this.prism.TabIndex = 3;
            this.prism.Text = "Prism";
            this.prism.UseVisualStyleBackColor = true;
            this.prism.Click += new System.EventHandler(this.prism_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 675);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edge Size";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(96, 675);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(214, 22);
            this.length.TabIndex = 5;
            // 
            // posx
            // 
            this.posx.Location = new System.Drawing.Point(455, 672);
            this.posx.Name = "posx";
            this.posx.Size = new System.Drawing.Size(60, 22);
            this.posx.TabIndex = 6;
            this.posx.Text = "0";
            this.posx.TextChanged += new System.EventHandler(this.posx_TextChanged);
            // 
            // posy
            // 
            this.posy.Location = new System.Drawing.Point(548, 672);
            this.posy.Name = "posy";
            this.posy.Size = new System.Drawing.Size(60, 22);
            this.posy.TabIndex = 7;
            this.posy.Text = "0";
            this.posy.TextChanged += new System.EventHandler(this.posy_TextChanged);
            // 
            // posz
            // 
            this.posz.Location = new System.Drawing.Point(644, 672);
            this.posz.Name = "posz";
            this.posz.Size = new System.Drawing.Size(60, 22);
            this.posz.TabIndex = 8;
            this.posz.Text = "0";
            this.posz.TextChanged += new System.EventHandler(this.posz_TextChanged);
            // 
            // scalez
            // 
            this.scalez.Location = new System.Drawing.Point(644, 711);
            this.scalez.Name = "scalez";
            this.scalez.Size = new System.Drawing.Size(60, 22);
            this.scalez.TabIndex = 11;
            this.scalez.Text = "1";
            this.scalez.TextChanged += new System.EventHandler(this.scalez_TextChanged);
            // 
            // scaley
            // 
            this.scaley.Location = new System.Drawing.Point(548, 711);
            this.scaley.Name = "scaley";
            this.scaley.Size = new System.Drawing.Size(60, 22);
            this.scaley.TabIndex = 10;
            this.scaley.Text = "1";
            this.scaley.TextChanged += new System.EventHandler(this.scaley_TextChanged);
            // 
            // scalex
            // 
            this.scalex.Location = new System.Drawing.Point(455, 711);
            this.scalex.Name = "scalex";
            this.scalex.Size = new System.Drawing.Size(60, 22);
            this.scalex.TabIndex = 9;
            this.scalex.Text = "1";
            this.scalex.TextChanged += new System.EventHandler(this.scalex_TextChanged);
            // 
            // rotatez
            // 
            this.rotatez.Location = new System.Drawing.Point(644, 750);
            this.rotatez.Name = "rotatez";
            this.rotatez.Size = new System.Drawing.Size(60, 22);
            this.rotatez.TabIndex = 14;
            this.rotatez.Text = "0";
            this.rotatez.TextChanged += new System.EventHandler(this.rotatez_TextChanged);
            // 
            // rotatey
            // 
            this.rotatey.Location = new System.Drawing.Point(548, 750);
            this.rotatey.Name = "rotatey";
            this.rotatey.Size = new System.Drawing.Size(60, 22);
            this.rotatey.TabIndex = 13;
            this.rotatey.Text = "0";
            this.rotatey.TextChanged += new System.EventHandler(this.rotatey_TextChanged);
            // 
            // rotatex
            // 
            this.rotatex.Location = new System.Drawing.Point(455, 750);
            this.rotatex.Name = "rotatex";
            this.rotatex.Size = new System.Drawing.Size(60, 22);
            this.rotatex.TabIndex = 12;
            this.rotatex.Text = "0";
            this.rotatex.TextChanged += new System.EventHandler(this.rotatex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(160, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "DRAW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(531, 629);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "TRANFORM";
            // 
            // openexplorer
            // 
            this.openexplorer.Location = new System.Drawing.Point(773, 668);
            this.openexplorer.Name = "openexplorer";
            this.openexplorer.Size = new System.Drawing.Size(83, 32);
            this.openexplorer.TabIndex = 20;
            this.openexplorer.Text = "Open File";
            this.openexplorer.UseVisualStyleBackColor = true;
            this.openexplorer.Click += new System.EventHandler(this.openexplorer_Click);
            // 
            // applytexture
            // 
            this.applytexture.Location = new System.Drawing.Point(773, 706);
            this.applytexture.Name = "applytexture";
            this.applytexture.Size = new System.Drawing.Size(83, 32);
            this.applytexture.TabIndex = 21;
            this.applytexture.Text = "Apply";
            this.applytexture.UseVisualStyleBackColor = true;
            this.applytexture.Click += new System.EventHandler(this.applytexture_Click);
            // 
            // canceltexture
            // 
            this.canceltexture.Location = new System.Drawing.Point(773, 744);
            this.canceltexture.Name = "canceltexture";
            this.canceltexture.Size = new System.Drawing.Size(83, 32);
            this.canceltexture.TabIndex = 22;
            this.canceltexture.Text = "Cancel";
            this.canceltexture.UseVisualStyleBackColor = true;
            this.canceltexture.Click += new System.EventHandler(this.canceltexture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(776, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "TEXTURE";
            // 
            // objectlist
            // 
            this.objectlist.FormattingEnabled = true;
            this.objectlist.ItemHeight = 16;
            this.objectlist.Location = new System.Drawing.Point(1196, 46);
            this.objectlist.Name = "objectlist";
            this.objectlist.Size = new System.Drawing.Size(223, 564);
            this.objectlist.TabIndex = 24;
            this.objectlist.SelectedIndexChanged += new System.EventHandler(this.objectlist_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(939, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "COLOR";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(931, 667);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(83, 32);
            this.color.TabIndex = 26;
            this.color.Text = "Choose";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 714);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Scale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 753);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Rotate";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.BackColor = System.Drawing.Color.Black;
            this.lbx.ForeColor = System.Drawing.Color.Red;
            this.lbx.Location = new System.Drawing.Point(20, 23);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(18, 17);
            this.lbx.TabIndex = 30;
            this.lbx.Text = "x:";
            // 
            // lby
            // 
            this.lby.AutoSize = true;
            this.lby.BackColor = System.Drawing.Color.Black;
            this.lby.ForeColor = System.Drawing.Color.Red;
            this.lby.Location = new System.Drawing.Point(20, 52);
            this.lby.Name = "lby";
            this.lby.Size = new System.Drawing.Size(19, 17);
            this.lby.TabIndex = 31;
            this.lby.Text = "y:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "z:";
            // 
            // cury
            // 
            this.cury.AutoSize = true;
            this.cury.Location = new System.Drawing.Point(45, 52);
            this.cury.Name = "cury";
            this.cury.Size = new System.Drawing.Size(0, 17);
            this.cury.TabIndex = 34;
            // 
            // curx
            // 
            this.curx.AutoSize = true;
            this.curx.Location = new System.Drawing.Point(45, 23);
            this.curx.Name = "curx";
            this.curx.Size = new System.Drawing.Size(0, 17);
            this.curx.TabIndex = 35;
            // 
            // curz
            // 
            this.curz.AutoSize = true;
            this.curz.Location = new System.Drawing.Point(47, 82);
            this.curz.Name = "curz";
            this.curz.Size = new System.Drawing.Size(0, 17);
            this.curz.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(663, 652);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 652);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 39;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1253, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "OBJECT LIST";
            // 
            // showgrid
            // 
            this.showgrid.AutoSize = true;
            this.showgrid.Checked = true;
            this.showgrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showgrid.Location = new System.Drawing.Point(1074, 671);
            this.showgrid.Name = "showgrid";
            this.showgrid.Size = new System.Drawing.Size(95, 21);
            this.showgrid.TabIndex = 41;
            this.showgrid.Text = "Show Grid";
            this.showgrid.UseVisualStyleBackColor = true;
            this.showgrid.CheckedChanged += new System.EventHandler(this.showgrid_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(1083, 634);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "CONFIG";
            // 
            // canmovecam
            // 
            this.canmovecam.AutoSize = true;
            this.canmovecam.Checked = true;
            this.canmovecam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canmovecam.Location = new System.Drawing.Point(1074, 698);
            this.canmovecam.Name = "canmovecam";
            this.canmovecam.Size = new System.Drawing.Size(146, 21);
            this.canmovecam.TabIndex = 43;
            this.canmovecam.Text = "Can Move Camera";
            this.canmovecam.UseVisualStyleBackColor = true;
            this.canmovecam.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 781);
            this.Controls.Add(this.canmovecam);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.showgrid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curz);
            this.Controls.Add(this.curx);
            this.Controls.Add(this.cury);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lby);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.objectlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.canceltexture);
            this.Controls.Add(this.applytexture);
            this.Controls.Add(this.openexplorer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotatez);
            this.Controls.Add(this.rotatey);
            this.Controls.Add(this.rotatex);
            this.Controls.Add(this.scalez);
            this.Controls.Add(this.scaley);
            this.Controls.Add(this.scalex);
            this.Controls.Add(this.posz);
            this.Controls.Add(this.posy);
            this.Controls.Add(this.posx);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prism);
            this.Controls.Add(this.pyramid);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.openGLControl);
            this.Name = "Form1";
            this.Text = "18127051_BT7";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button cube;
        private System.Windows.Forms.Button pyramid;
        private System.Windows.Forms.Button prism;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox posx;
        private System.Windows.Forms.TextBox posy;
        private System.Windows.Forms.TextBox posz;
        private System.Windows.Forms.TextBox scalez;
        private System.Windows.Forms.TextBox scaley;
        private System.Windows.Forms.TextBox scalex;
        private System.Windows.Forms.TextBox rotatez;
        private System.Windows.Forms.TextBox rotatey;
        private System.Windows.Forms.TextBox rotatex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openexplorer;
        private System.Windows.Forms.Button applytexture;
        private System.Windows.Forms.Button canceltexture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox objectlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorpicker;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lby;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cury;
        private System.Windows.Forms.Label curx;
        private System.Windows.Forms.Label curz;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox showgrid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox canmovecam;
    }
}

