
namespace MovieFront
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genres = new System.Windows.Forms.ToolStripMenuItem();
            this.Actors = new System.Windows.Forms.ToolStripMenuItem();
            this.directors = new System.Windows.Forms.ToolStripMenuItem();
            this.ratingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Eight = new System.Windows.Forms.ToolStripMenuItem();
            this.sixtoeight = new System.Windows.Forms.ToolStripMenuItem();
            this.fourtosix = new System.Windows.Forms.ToolStripMenuItem();
            this.twotofour = new System.Windows.Forms.ToolStripMenuItem();
            this.belowtwo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.genres,
            this.Actors,
            this.directors,
            this.ratingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 44);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.moviesToolStripMenuItem.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviesToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(112, 40);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // genres
            // 
            this.genres.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genres.ForeColor = System.Drawing.Color.Goldenrod;
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(112, 40);
            this.genres.Text = "Genres";
            this.genres.Click += new System.EventHandler(this.genres_Click);
            // 
            // Actors
            // 
            this.Actors.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actors.ForeColor = System.Drawing.Color.Goldenrod;
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(103, 40);
            this.Actors.Text = "Actors";
            this.Actors.Click += new System.EventHandler(this.Actors_Click);
            // 
            // directors
            // 
            this.directors.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directors.ForeColor = System.Drawing.Color.Goldenrod;
            this.directors.Name = "directors";
            this.directors.Size = new System.Drawing.Size(138, 40);
            this.directors.Text = "Directors";
            this.directors.Click += new System.EventHandler(this.directors_Click);
            // 
            // ratingToolStripMenuItem
            // 
            this.ratingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Eight,
            this.sixtoeight,
            this.fourtosix,
            this.twotofour,
            this.belowtwo});
            this.ratingToolStripMenuItem.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.ratingToolStripMenuItem.Name = "ratingToolStripMenuItem";
            this.ratingToolStripMenuItem.Size = new System.Drawing.Size(105, 40);
            this.ratingToolStripMenuItem.Text = "Rating";
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Black;
            this.Eight.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.ForeColor = System.Drawing.Color.Goldenrod;
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(173, 24);
            this.Eight.Text = "8 stars and up";
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // sixtoeight
            // 
            this.sixtoeight.BackColor = System.Drawing.Color.Black;
            this.sixtoeight.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixtoeight.ForeColor = System.Drawing.Color.Goldenrod;
            this.sixtoeight.Name = "sixtoeight";
            this.sixtoeight.Size = new System.Drawing.Size(173, 24);
            this.sixtoeight.Text = "6-8 stars";
            this.sixtoeight.Click += new System.EventHandler(this.sixtoeight_Click);
            // 
            // fourtosix
            // 
            this.fourtosix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fourtosix.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourtosix.ForeColor = System.Drawing.Color.Goldenrod;
            this.fourtosix.Name = "fourtosix";
            this.fourtosix.Size = new System.Drawing.Size(173, 24);
            this.fourtosix.Text = "4-6 stars";
            this.fourtosix.Click += new System.EventHandler(this.fourtosix_Click);
            // 
            // twotofour
            // 
            this.twotofour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.twotofour.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twotofour.ForeColor = System.Drawing.Color.Goldenrod;
            this.twotofour.Name = "twotofour";
            this.twotofour.Size = new System.Drawing.Size(173, 24);
            this.twotofour.Text = "2-4 stars ";
            this.twotofour.Click += new System.EventHandler(this.twotofour_Click);
            // 
            // belowtwo
            // 
            this.belowtwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.belowtwo.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belowtwo.ForeColor = System.Drawing.Color.Goldenrod;
            this.belowtwo.Name = "belowtwo";
            this.belowtwo.Size = new System.Drawing.Size(173, 24);
            this.belowtwo.Text = "below 2 stars";
            this.belowtwo.Click += new System.EventHandler(this.belowtwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 715);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genres;
        private System.Windows.Forms.ToolStripMenuItem Actors;
        private System.Windows.Forms.ToolStripMenuItem directors;
        private System.Windows.Forms.ToolStripMenuItem ratingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Eight;
        private System.Windows.Forms.ToolStripMenuItem sixtoeight;
        private System.Windows.Forms.ToolStripMenuItem fourtosix;
        private System.Windows.Forms.ToolStripMenuItem twotofour;
        private System.Windows.Forms.ToolStripMenuItem belowtwo;
    }
}

