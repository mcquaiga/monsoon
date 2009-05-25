// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monsoon {
    
    
    public partial class RssManagerDialog {
        
        private Gtk.Notebook notebook1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label5;
        
        private Gtk.Entry feedUrlEntry;
        
        private Gtk.HBox hbox2;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView feedTreeView;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Button addFeedButton;
        
        private Gtk.Button removeFeedButton;
        
        private Gtk.Label label1;
        
        private Gtk.HBox hbox3;
        
        private Gtk.VBox vbox4;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView filterTreeView;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Button addFilterButton;
        
        private Gtk.Button removeFilterButton;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment4;
        
        private Gtk.Table filterTable;
        
        private Gtk.Entry excludeEntry;
        
        private Gtk.ComboBox filterFeedCombobox;
        
        private Gtk.Entry includeEntry;
        
        private Gtk.Label label10;
        
        private Gtk.Label label11;
        
        private Gtk.Label label6;
        
        private Gtk.Label label7;
        
        private Gtk.Label label8;
        
        private Gtk.Label label9;
        
        private Gtk.ComboBox labelCombobox;
        
        private Gtk.Entry nameEntry;
        
        private Gtk.Label GtkLabel6;
        
        private Gtk.Label label2;
        
        private Gtk.VBox vbox5;
        
        private Gtk.HBox hbox5;
        
        private Gtk.ComboBox feedCombobox;
        
        private Gtk.Button refreshFeedButton;
        
        private Gtk.ScrolledWindow scrolledwindow3;
        
        private Gtk.TreeView itemTreeView;
        
        private Gtk.Label label3;
        
        private Gtk.HBox hbox6;
        
        private Gtk.ScrolledWindow scrolledwindow4;
        
        private Gtk.TreeView historyTreeView;
        
        private Gtk.VBox vbox6;
        
        private Gtk.Button removeHistoryButton;
        
        private Gtk.Button clearHistoryButton;
        
        private Gtk.Label label4;
        
        private Gtk.Button Close;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Monsoon.RssManagerDialog
            this.Name = "Monsoon.RssManagerDialog";
            this.Title = Mono.Unix.Catalog.GetString("Monsoon RSS Manager");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            // Internal child Monsoon.RssManagerDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.notebook1 = new Gtk.Notebook();
            this.notebook1.CanFocus = true;
            this.notebook1.Name = "notebook1";
            this.notebook1.CurrentPage = 2;
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(5));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("RSS Feed:");
            this.hbox1.Add(this.label5);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.label5]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.feedUrlEntry = new Gtk.Entry();
            this.feedUrlEntry.CanFocus = true;
            this.feedUrlEntry.Name = "feedUrlEntry";
            this.feedUrlEntry.IsEditable = true;
            this.feedUrlEntry.InvisibleChar = '●';
            this.hbox1.Add(this.feedUrlEntry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.feedUrlEntry]));
            w3.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.feedTreeView = new Gtk.TreeView();
            this.feedTreeView.CanFocus = true;
            this.feedTreeView.Name = "feedTreeView";
            this.feedTreeView.HeadersVisible = false;
            this.scrolledwindow1.Add(this.feedTreeView);
            this.hbox2.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox2[this.scrolledwindow1]));
            w6.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.addFeedButton = new Gtk.Button();
            this.addFeedButton.CanFocus = true;
            this.addFeedButton.Name = "addFeedButton";
            this.addFeedButton.UseStock = true;
            this.addFeedButton.UseUnderline = true;
            this.addFeedButton.Label = "gtk-add";
            this.vbox3.Add(this.addFeedButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox3[this.addFeedButton]));
            w7.Position = 0;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.removeFeedButton = new Gtk.Button();
            this.removeFeedButton.CanFocus = true;
            this.removeFeedButton.Name = "removeFeedButton";
            this.removeFeedButton.UseStock = true;
            this.removeFeedButton.UseUnderline = true;
            this.removeFeedButton.Label = "gtk-remove";
            this.vbox3.Add(this.removeFeedButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.removeFeedButton]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            this.hbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox2.Add(this.hbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
            w10.Position = 1;
            this.notebook1.Add(this.vbox2);
            // Notebook tab
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Feeds");
            this.notebook1.SetTabLabel(this.vbox2, this.label1);
            this.label1.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            this.hbox3.BorderWidth = ((uint)(5));
            // Container child hbox3.Gtk.Box+BoxChild
            this.vbox4 = new Gtk.VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.filterTreeView = new Gtk.TreeView();
            this.filterTreeView.CanFocus = true;
            this.filterTreeView.Name = "filterTreeView";
            this.filterTreeView.HeadersVisible = false;
            this.scrolledwindow2.Add(this.filterTreeView);
            this.vbox4.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.vbox4[this.scrolledwindow2]));
            w13.Position = 0;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.addFilterButton = new Gtk.Button();
            this.addFilterButton.CanFocus = true;
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.UseStock = true;
            this.addFilterButton.UseUnderline = true;
            this.addFilterButton.Label = "gtk-add";
            this.hbox4.Add(this.addFilterButton);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox4[this.addFilterButton]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.removeFilterButton = new Gtk.Button();
            this.removeFilterButton.CanFocus = true;
            this.removeFilterButton.Name = "removeFilterButton";
            this.removeFilterButton.UseStock = true;
            this.removeFilterButton.UseUnderline = true;
            this.removeFilterButton.Label = "gtk-remove";
            this.hbox4.Add(this.removeFilterButton);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox4[this.removeFilterButton]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.vbox4.Add(this.hbox4);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
            w16.Position = 1;
            w16.Expand = false;
            w16.Fill = false;
            this.hbox3.Add(this.vbox4);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox3[this.vbox4]));
            w17.Position = 0;
            w17.Expand = false;
            w17.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment4 = new Gtk.Alignment(1F, 0F, 1F, 1F);
            this.GtkAlignment4.Name = "GtkAlignment4";
            this.GtkAlignment4.LeftPadding = ((uint)(12));
            // Container child GtkAlignment4.Gtk.Container+ContainerChild
            this.filterTable = new Gtk.Table(((uint)(7)), ((uint)(2)), false);
            this.filterTable.Name = "filterTable";
            this.filterTable.RowSpacing = ((uint)(6));
            this.filterTable.ColumnSpacing = ((uint)(6));
            // Container child filterTable.Gtk.Table+TableChild
            this.excludeEntry = new Gtk.Entry();
            this.excludeEntry.CanFocus = true;
            this.excludeEntry.Name = "excludeEntry";
            this.excludeEntry.IsEditable = true;
            this.excludeEntry.InvisibleChar = '●';
            this.filterTable.Add(this.excludeEntry);
            Gtk.Table.TableChild w18 = ((Gtk.Table.TableChild)(this.filterTable[this.excludeEntry]));
            w18.TopAttach = ((uint)(2));
            w18.BottomAttach = ((uint)(3));
            w18.LeftAttach = ((uint)(1));
            w18.RightAttach = ((uint)(2));
            w18.XOptions = ((Gtk.AttachOptions)(4));
            w18.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.filterFeedCombobox = new Gtk.ComboBox();
            this.filterFeedCombobox.Name = "filterFeedCombobox";
            this.filterTable.Add(this.filterFeedCombobox);
            Gtk.Table.TableChild w19 = ((Gtk.Table.TableChild)(this.filterTable[this.filterFeedCombobox]));
            w19.TopAttach = ((uint)(4));
            w19.BottomAttach = ((uint)(5));
            w19.LeftAttach = ((uint)(1));
            w19.RightAttach = ((uint)(2));
            w19.XOptions = ((Gtk.AttachOptions)(4));
            w19.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.includeEntry = new Gtk.Entry();
            this.includeEntry.CanFocus = true;
            this.includeEntry.Name = "includeEntry";
            this.includeEntry.IsEditable = true;
            this.includeEntry.InvisibleChar = '●';
            this.filterTable.Add(this.includeEntry);
            Gtk.Table.TableChild w20 = ((Gtk.Table.TableChild)(this.filterTable[this.includeEntry]));
            w20.TopAttach = ((uint)(1));
            w20.BottomAttach = ((uint)(2));
            w20.LeftAttach = ((uint)(1));
            w20.RightAttach = ((uint)(2));
            w20.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label10 = new Gtk.Label();
            this.label10.Name = "label10";
            this.label10.Xalign = 0F;
            this.label10.LabelProp = Mono.Unix.Catalog.GetString("Name:");
            this.filterTable.Add(this.label10);
            Gtk.Table.TableChild w21 = ((Gtk.Table.TableChild)(this.filterTable[this.label10]));
            w21.XOptions = ((Gtk.AttachOptions)(4));
            w21.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label11 = new Gtk.Label();
            this.label11.Name = "label11";
            this.label11.Xalign = 0F;
            this.label11.LabelProp = Mono.Unix.Catalog.GetString("Feed:");
            this.filterTable.Add(this.label11);
            Gtk.Table.TableChild w22 = ((Gtk.Table.TableChild)(this.filterTable[this.label11]));
            w22.TopAttach = ((uint)(4));
            w22.BottomAttach = ((uint)(5));
            w22.XOptions = ((Gtk.AttachOptions)(4));
            w22.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.Xalign = 0F;
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Filter:");
            this.filterTable.Add(this.label6);
            Gtk.Table.TableChild w23 = ((Gtk.Table.TableChild)(this.filterTable[this.label6]));
            w23.TopAttach = ((uint)(1));
            w23.BottomAttach = ((uint)(2));
            w23.XOptions = ((Gtk.AttachOptions)(4));
            w23.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.Xalign = 0F;
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Exclude:");
            this.filterTable.Add(this.label7);
            Gtk.Table.TableChild w24 = ((Gtk.Table.TableChild)(this.filterTable[this.label7]));
            w24.TopAttach = ((uint)(2));
            w24.BottomAttach = ((uint)(3));
            w24.XOptions = ((Gtk.AttachOptions)(4));
            w24.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Save Path:");
            this.filterTable.Add(this.label8);
            Gtk.Table.TableChild w25 = ((Gtk.Table.TableChild)(this.filterTable[this.label8]));
            w25.TopAttach = ((uint)(3));
            w25.BottomAttach = ((uint)(4));
            w25.XOptions = ((Gtk.AttachOptions)(4));
            w25.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.Xalign = 0F;
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("Label:");
            this.filterTable.Add(this.label9);
            Gtk.Table.TableChild w26 = ((Gtk.Table.TableChild)(this.filterTable[this.label9]));
            w26.TopAttach = ((uint)(5));
            w26.BottomAttach = ((uint)(6));
            w26.XOptions = ((Gtk.AttachOptions)(4));
            w26.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.labelCombobox = new Gtk.ComboBox();
            this.labelCombobox.Name = "labelCombobox";
            this.filterTable.Add(this.labelCombobox);
            Gtk.Table.TableChild w27 = ((Gtk.Table.TableChild)(this.filterTable[this.labelCombobox]));
            w27.TopAttach = ((uint)(5));
            w27.BottomAttach = ((uint)(6));
            w27.LeftAttach = ((uint)(1));
            w27.RightAttach = ((uint)(2));
            w27.XOptions = ((Gtk.AttachOptions)(4));
            w27.YOptions = ((Gtk.AttachOptions)(4));
            // Container child filterTable.Gtk.Table+TableChild
            this.nameEntry = new Gtk.Entry();
            this.nameEntry.CanFocus = true;
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.IsEditable = true;
            this.nameEntry.InvisibleChar = '●';
            this.filterTable.Add(this.nameEntry);
            Gtk.Table.TableChild w28 = ((Gtk.Table.TableChild)(this.filterTable[this.nameEntry]));
            w28.LeftAttach = ((uint)(1));
            w28.RightAttach = ((uint)(2));
            w28.XOptions = ((Gtk.AttachOptions)(4));
            w28.YOptions = ((Gtk.AttachOptions)(4));
            this.GtkAlignment4.Add(this.filterTable);
            this.frame1.Add(this.GtkAlignment4);
            this.GtkLabel6 = new Gtk.Label();
            this.GtkLabel6.Name = "GtkLabel6";
            this.GtkLabel6.LabelProp = Mono.Unix.Catalog.GetString("<b>Filter Settings</b>");
            this.GtkLabel6.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel6;
            this.hbox3.Add(this.frame1);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox3[this.frame1]));
            w31.Position = 1;
            this.notebook1.Add(this.hbox3);
            Gtk.Notebook.NotebookChild w32 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.hbox3]));
            w32.Position = 1;
            // Notebook tab
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Filters");
            this.notebook1.SetTabLabel(this.hbox3, this.label2);
            this.label2.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.vbox5 = new Gtk.VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Spacing = 6;
            this.vbox5.BorderWidth = ((uint)(5));
            // Container child vbox5.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.feedCombobox = new Gtk.ComboBox();
            this.feedCombobox.Name = "feedCombobox";
            this.hbox5.Add(this.feedCombobox);
            Gtk.Box.BoxChild w33 = ((Gtk.Box.BoxChild)(this.hbox5[this.feedCombobox]));
            w33.Position = 0;
            // Container child hbox5.Gtk.Box+BoxChild
            this.refreshFeedButton = new Gtk.Button();
            this.refreshFeedButton.CanFocus = true;
            this.refreshFeedButton.Name = "refreshFeedButton";
            this.refreshFeedButton.UseStock = true;
            this.refreshFeedButton.UseUnderline = true;
            this.refreshFeedButton.Label = "gtk-refresh";
            this.hbox5.Add(this.refreshFeedButton);
            Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(this.hbox5[this.refreshFeedButton]));
            w34.Position = 1;
            w34.Expand = false;
            w34.Fill = false;
            this.vbox5.Add(this.hbox5);
            Gtk.Box.BoxChild w35 = ((Gtk.Box.BoxChild)(this.vbox5[this.hbox5]));
            w35.Position = 0;
            w35.Expand = false;
            w35.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.scrolledwindow3 = new Gtk.ScrolledWindow();
            this.scrolledwindow3.CanFocus = true;
            this.scrolledwindow3.Name = "scrolledwindow3";
            this.scrolledwindow3.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow3.Gtk.Container+ContainerChild
            this.itemTreeView = new Gtk.TreeView();
            this.itemTreeView.CanFocus = true;
            this.itemTreeView.Name = "itemTreeView";
            this.itemTreeView.HeadersVisible = false;
            this.scrolledwindow3.Add(this.itemTreeView);
            this.vbox5.Add(this.scrolledwindow3);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.vbox5[this.scrolledwindow3]));
            w37.Position = 1;
            this.notebook1.Add(this.vbox5);
            Gtk.Notebook.NotebookChild w38 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.vbox5]));
            w38.Position = 2;
            // Notebook tab
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Torrents");
            this.notebook1.SetTabLabel(this.vbox5, this.label3);
            this.label3.ShowAll();
            // Container child notebook1.Gtk.Notebook+NotebookChild
            this.hbox6 = new Gtk.HBox();
            this.hbox6.Name = "hbox6";
            this.hbox6.Spacing = 6;
            this.hbox6.BorderWidth = ((uint)(5));
            // Container child hbox6.Gtk.Box+BoxChild
            this.scrolledwindow4 = new Gtk.ScrolledWindow();
            this.scrolledwindow4.CanFocus = true;
            this.scrolledwindow4.Name = "scrolledwindow4";
            this.scrolledwindow4.ShadowType = ((Gtk.ShadowType)(1));
            this.scrolledwindow4.BorderWidth = ((uint)(5));
            // Container child scrolledwindow4.Gtk.Container+ContainerChild
            this.historyTreeView = new Gtk.TreeView();
            this.historyTreeView.CanFocus = true;
            this.historyTreeView.Name = "historyTreeView";
            this.scrolledwindow4.Add(this.historyTreeView);
            this.hbox6.Add(this.scrolledwindow4);
            Gtk.Box.BoxChild w40 = ((Gtk.Box.BoxChild)(this.hbox6[this.scrolledwindow4]));
            w40.Position = 0;
            // Container child hbox6.Gtk.Box+BoxChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            // Container child vbox6.Gtk.Box+BoxChild
            this.removeHistoryButton = new Gtk.Button();
            this.removeHistoryButton.CanFocus = true;
            this.removeHistoryButton.Name = "removeHistoryButton";
            this.removeHistoryButton.UseStock = true;
            this.removeHistoryButton.UseUnderline = true;
            this.removeHistoryButton.Label = "gtk-remove";
            this.vbox6.Add(this.removeHistoryButton);
            Gtk.Box.BoxChild w41 = ((Gtk.Box.BoxChild)(this.vbox6[this.removeHistoryButton]));
            w41.Position = 0;
            w41.Expand = false;
            w41.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.clearHistoryButton = new Gtk.Button();
            this.clearHistoryButton.CanFocus = true;
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.UseStock = true;
            this.clearHistoryButton.UseUnderline = true;
            this.clearHistoryButton.Label = "gtk-clear";
            this.vbox6.Add(this.clearHistoryButton);
            Gtk.Box.BoxChild w42 = ((Gtk.Box.BoxChild)(this.vbox6[this.clearHistoryButton]));
            w42.Position = 1;
            w42.Expand = false;
            w42.Fill = false;
            this.hbox6.Add(this.vbox6);
            Gtk.Box.BoxChild w43 = ((Gtk.Box.BoxChild)(this.hbox6[this.vbox6]));
            w43.Position = 1;
            w43.Expand = false;
            w43.Fill = false;
            this.notebook1.Add(this.hbox6);
            Gtk.Notebook.NotebookChild w44 = ((Gtk.Notebook.NotebookChild)(this.notebook1[this.hbox6]));
            w44.Position = 3;
            // Notebook tab
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("History");
            this.notebook1.SetTabLabel(this.hbox6, this.label4);
            this.label4.ShowAll();
            w1.Add(this.notebook1);
            Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(w1[this.notebook1]));
            w45.Position = 0;
            // Internal child Monsoon.RssManagerDialog.ActionArea
            Gtk.HButtonBox w46 = this.ActionArea;
            w46.Name = "GtkDialog_ActionArea";
            w46.Spacing = 6;
            w46.BorderWidth = ((uint)(5));
            w46.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child GtkDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.Close = new Gtk.Button();
            this.Close.CanFocus = true;
            this.Close.Name = "Close";
            this.Close.UseUnderline = true;
            this.Close.Label = Mono.Unix.Catalog.GetString("Close");
            this.AddActionWidget(this.Close, 0);
            Gtk.ButtonBox.ButtonBoxChild w47 = ((Gtk.ButtonBox.ButtonBoxChild)(w46[this.Close]));
            w47.Expand = false;
            w47.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 549;
            this.DefaultHeight = 384;
            this.label9.Hide();
            this.labelCombobox.Hide();
            this.Show();
            this.addFeedButton.Clicked += new System.EventHandler(this.OnAddFeedButtonClicked);
            this.removeFeedButton.Clicked += new System.EventHandler(this.OnRemoveFeedButtonClicked);
            this.addFilterButton.Clicked += new System.EventHandler(this.OnAddFilterButtonClicked);
            this.removeFilterButton.Clicked += new System.EventHandler(this.OnRemoveFilterButtonClicked);
            this.refreshFeedButton.Clicked += new System.EventHandler(this.OnRefreshFeedButtonClicked);
            this.removeHistoryButton.Clicked += new System.EventHandler(this.OnRemoveHistoryButtonClicked);
            this.clearHistoryButton.Clicked += new System.EventHandler(this.OnClearHistoryButtonClicked);
        }
    }
}
