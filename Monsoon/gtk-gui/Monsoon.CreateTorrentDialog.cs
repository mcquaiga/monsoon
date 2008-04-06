// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monsoon {
    
    
    public partial class CreateTorrentDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment2;
        
        private Gtk.VBox vbox5;
        
        private Gtk.HBox selectFileHbox;
        
        private Gtk.Label label1;
        
        private Gtk.Table table1;
        
        private Gtk.RadioButton fileRadioButton;
        
        private Gtk.RadioButton folderRadioButton;
        
        private Gtk.Label GtkLabel2;
        
        private Gtk.Frame frame2;
        
        private Gtk.Alignment GtkAlignment3;
        
        private Gtk.HBox hbox2;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Entry trackerEntry;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView trackerTreeView;
        
        private Gtk.VBox vbox4;
        
        private Gtk.Button addTrackerButton;
        
        private Gtk.Button removeTrackerButton;
        
        private Gtk.Label GtkLabel5;
        
        private Gtk.Frame frame3;
        
        private Gtk.Alignment GtkAlignment4;
        
        private Gtk.VBox vbox6;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label3;
        
        private Gtk.Entry commentEntry;
        
        private Gtk.HBox hbox5;
        
        private Gtk.CheckButton startSeedingCheckBox;
        
        private Gtk.HBox hbox6;
        
        private Gtk.CheckButton hiddenFilesCheckBox;
        
        private Gtk.Label GtkLabel8;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Monsoon.CreateTorrentDialog
            this.Name = "Monsoon.CreateTorrentDialog";
            this.Title = Mono.Unix.Catalog.GetString("Create a torrent");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child Monsoon.CreateTorrentDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment2 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment2.Name = "GtkAlignment2";
            this.GtkAlignment2.LeftPadding = ((uint)(12));
            // Container child GtkAlignment2.Gtk.Container+ContainerChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.selectFileHbox = new Gtk.HBox();
            this.selectFileHbox.Name = "selectFileHbox";
            this.selectFileHbox.Spacing = 6;
            // Container child selectFileHbox.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Path:");
            this.selectFileHbox.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.selectFileHbox[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.vbox5.Add(this.selectFileHbox);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox5[this.selectFileHbox]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(1)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.fileRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Single File"));
            this.fileRadioButton.CanFocus = true;
            this.fileRadioButton.Name = "fileRadioButton";
            this.fileRadioButton.DrawIndicator = true;
            this.fileRadioButton.UseUnderline = true;
            this.fileRadioButton.Group = new GLib.SList(System.IntPtr.Zero);
            this.table1.Add(this.fileRadioButton);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.fileRadioButton]));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.folderRadioButton = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Folder"));
            this.folderRadioButton.CanFocus = true;
            this.folderRadioButton.Name = "folderRadioButton";
            this.folderRadioButton.DrawIndicator = true;
            this.folderRadioButton.UseUnderline = true;
            this.folderRadioButton.Group = this.fileRadioButton.Group;
            this.table1.Add(this.folderRadioButton);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.folderRadioButton]));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox5.Add(this.table1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox5[this.table1]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            this.GtkAlignment2.Add(this.vbox5);
            this.frame1.Add(this.GtkAlignment2);
            this.GtkLabel2 = new Gtk.Label();
            this.GtkLabel2.Name = "GtkLabel2";
            this.GtkLabel2.LabelProp = Mono.Unix.Catalog.GetString("<b>Select source</b>");
            this.GtkLabel2.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel2;
            this.vbox2.Add(this.frame1);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.frame1]));
            w9.Position = 0;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.frame2 = new Gtk.Frame();
            this.frame2.Name = "frame2";
            this.frame2.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame2.Gtk.Container+ContainerChild
            this.GtkAlignment3 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment3.Name = "GtkAlignment3";
            this.GtkAlignment3.LeftPadding = ((uint)(12));
            // Container child GtkAlignment3.Gtk.Container+ContainerChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.trackerEntry = new Gtk.Entry();
            this.trackerEntry.CanFocus = true;
            this.trackerEntry.Name = "trackerEntry";
            this.trackerEntry.IsEditable = true;
            this.trackerEntry.InvisibleChar = '●';
            this.vbox3.Add(this.trackerEntry);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox3[this.trackerEntry]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.trackerTreeView = new Gtk.TreeView();
            this.trackerTreeView.CanFocus = true;
            this.trackerTreeView.Name = "trackerTreeView";
            this.trackerTreeView.HeadersClickable = true;
            this.scrolledwindow1.Add(this.trackerTreeView);
            this.vbox3.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox3[this.scrolledwindow1]));
            w12.Position = 1;
            this.hbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
            w13.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.addTrackerButton = new Gtk.Button();
            this.addTrackerButton.Sensitive = false;
            this.addTrackerButton.CanFocus = true;
            this.addTrackerButton.Name = "addTrackerButton";
            this.addTrackerButton.UseUnderline = true;
            // Container child addTrackerButton.Gtk.Container+ContainerChild
            Gtk.Alignment w14 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w15 = new Gtk.HBox();
            w15.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w16 = new Gtk.Image();
            w16.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-add", Gtk.IconSize.Menu, 16);
            w15.Add(w16);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w18 = new Gtk.Label();
            w18.LabelProp = Mono.Unix.Catalog.GetString("Add");
            w18.UseUnderline = true;
            w15.Add(w18);
            w14.Add(w15);
            this.addTrackerButton.Add(w14);
            this.vbox4.Add(this.addTrackerButton);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.vbox4[this.addTrackerButton]));
            w22.Position = 0;
            w22.Expand = false;
            w22.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.removeTrackerButton = new Gtk.Button();
            this.removeTrackerButton.Sensitive = false;
            this.removeTrackerButton.CanFocus = true;
            this.removeTrackerButton.Name = "removeTrackerButton";
            this.removeTrackerButton.UseUnderline = true;
            // Container child removeTrackerButton.Gtk.Container+ContainerChild
            Gtk.Alignment w23 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            Gtk.HBox w24 = new Gtk.HBox();
            w24.Spacing = 2;
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Image w25 = new Gtk.Image();
            w25.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-remove", Gtk.IconSize.Menu, 16);
            w24.Add(w25);
            // Container child GtkHBox1.Gtk.Container+ContainerChild
            Gtk.Label w27 = new Gtk.Label();
            w27.LabelProp = Mono.Unix.Catalog.GetString("Remove");
            w27.UseUnderline = true;
            w24.Add(w27);
            w23.Add(w24);
            this.removeTrackerButton.Add(w23);
            this.vbox4.Add(this.removeTrackerButton);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.vbox4[this.removeTrackerButton]));
            w31.Position = 1;
            w31.Expand = false;
            w31.Fill = false;
            this.hbox2.Add(this.vbox4);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
            w32.Position = 1;
            w32.Expand = false;
            w32.Fill = false;
            this.GtkAlignment3.Add(this.hbox2);
            this.frame2.Add(this.GtkAlignment3);
            this.GtkLabel5 = new Gtk.Label();
            this.GtkLabel5.Name = "GtkLabel5";
            this.GtkLabel5.LabelProp = Mono.Unix.Catalog.GetString("<b>Set a tracker</b>");
            this.GtkLabel5.UseMarkup = true;
            this.frame2.LabelWidget = this.GtkLabel5;
            this.vbox2.Add(this.frame2);
            Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(this.vbox2[this.frame2]));
            w35.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.frame3 = new Gtk.Frame();
            this.frame3.Name = "frame3";
            this.frame3.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame3.Gtk.Container+ContainerChild
            this.GtkAlignment4 = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment4.Name = "GtkAlignment4";
            this.GtkAlignment4.LeftPadding = ((uint)(12));
            // Container child GtkAlignment4.Gtk.Container+ContainerChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Comment:");
            this.hbox4.Add(this.label3);
            Gtk.Box.BoxChild w36 = ((Gtk.Box.BoxChild)(this.hbox4[this.label3]));
            w36.Position = 0;
            w36.Expand = false;
            w36.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.commentEntry = new Gtk.Entry();
            this.commentEntry.CanFocus = true;
            this.commentEntry.Name = "commentEntry";
            this.commentEntry.IsEditable = true;
            this.commentEntry.InvisibleChar = '●';
            this.hbox4.Add(this.commentEntry);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.hbox4[this.commentEntry]));
            w37.Position = 1;
            this.vbox6.Add(this.hbox4);
            Gtk.Box.BoxChild w38 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox4]));
            w38.Position = 0;
            w38.Expand = false;
            w38.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.startSeedingCheckBox = new Gtk.CheckButton();
            this.startSeedingCheckBox.CanFocus = true;
            this.startSeedingCheckBox.Name = "startSeedingCheckBox";
            this.startSeedingCheckBox.Label = Mono.Unix.Catalog.GetString("Start seeding");
            this.startSeedingCheckBox.Active = true;
            this.startSeedingCheckBox.DrawIndicator = true;
            this.startSeedingCheckBox.UseUnderline = true;
            this.hbox5.Add(this.startSeedingCheckBox);
            Gtk.Box.BoxChild w39 = ((Gtk.Box.BoxChild)(this.hbox5[this.startSeedingCheckBox]));
            w39.Position = 0;
            this.vbox6.Add(this.hbox5);
            Gtk.Box.BoxChild w40 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox5]));
            w40.Position = 1;
            w40.Expand = false;
            w40.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.hbox6 = new Gtk.HBox();
            this.hbox6.Name = "hbox6";
            this.hbox6.Spacing = 6;
            // Container child hbox6.Gtk.Box+BoxChild
            this.hiddenFilesCheckBox = new Gtk.CheckButton();
            this.hiddenFilesCheckBox.CanFocus = true;
            this.hiddenFilesCheckBox.Name = "hiddenFilesCheckBox";
            this.hiddenFilesCheckBox.Label = Mono.Unix.Catalog.GetString("Ignore hidden files");
            this.hiddenFilesCheckBox.Active = true;
            this.hiddenFilesCheckBox.DrawIndicator = true;
            this.hiddenFilesCheckBox.UseUnderline = true;
            this.hbox6.Add(this.hiddenFilesCheckBox);
            Gtk.Box.BoxChild w41 = ((Gtk.Box.BoxChild)(this.hbox6[this.hiddenFilesCheckBox]));
            w41.Position = 0;
            this.vbox6.Add(this.hbox6);
            Gtk.Box.BoxChild w42 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
            w42.Position = 2;
            w42.Expand = false;
            w42.Fill = false;
            this.GtkAlignment4.Add(this.vbox6);
            this.frame3.Add(this.GtkAlignment4);
            this.GtkLabel8 = new Gtk.Label();
            this.GtkLabel8.Name = "GtkLabel8";
            this.GtkLabel8.LabelProp = Mono.Unix.Catalog.GetString("<b>Miscellaneous</b>");
            this.GtkLabel8.UseMarkup = true;
            this.frame3.LabelWidget = this.GtkLabel8;
            this.vbox2.Add(this.frame3);
            Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(this.vbox2[this.frame3]));
            w45.Position = 2;
            w45.Expand = false;
            w45.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w46 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w46.Position = 0;
            // Internal child Monsoon.CreateTorrentDialog.ActionArea
            Gtk.HButtonBox w47 = this.ActionArea;
            w47.Name = "GtkDialog_ActionArea";
            w47.Spacing = 6;
            w47.BorderWidth = ((uint)(5));
            w47.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w48 = ((Gtk.ButtonBox.ButtonBoxChild)(w47[this.buttonCancel]));
            w48.Expand = false;
            w48.Fill = false;
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.Sensitive = false;
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w49 = ((Gtk.ButtonBox.ButtonBoxChild)(w47[this.buttonOk]));
            w49.Position = 1;
            w49.Expand = false;
            w49.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 403;
            this.DefaultHeight = 438;
            this.Show();
            this.folderRadioButton.Toggled += new System.EventHandler(this.OnFolderRadioButtonToggled);
            this.fileRadioButton.Toggled += new System.EventHandler(this.OnFileRadioButtonToggled);
            this.trackerEntry.Changed += new System.EventHandler(this.OnTrackerEntryChanged);
            this.addTrackerButton.Clicked += new System.EventHandler(this.OnAddTrackerButtonClicked);
            this.removeTrackerButton.Clicked += new System.EventHandler(this.OnRemoveTrackerButtonClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnCreateButtonClicked);
        }
    }
}
