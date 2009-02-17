// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Synapse.QtClient.Windows {
    using System;
    using Qyoto;
    
    
    public partial class PreferencesWindow : QWidget {
        
        protected QTabWidget tabWidget;
        
        protected QWidget tab;
        
        protected QTableView accountsList;
        
        protected QWidget widget;
        
        protected QPushButton addAccountButton;
        
        protected QPushButton editAccountButton;
        
        protected QPushButton removeAccountButton;
        
        protected QWidget tab_4;
        
        protected QGroupBox groupBox_5;
        
        protected QLabel label_4;
        
        protected QComboBox comboBox_3;
        
        protected QSlider horizontalSlider;
        
        protected QComboBox comboBox_4;
        
        protected QLabel label_7;
        
        protected QLabel label_5;
        
        protected QGroupBox groupBox_4;
        
        protected QLabel label_6;
        
        protected QWidget tab_5;
        
        protected QGroupBox groupBox_3;
        
        protected QLabel label;
        
        protected QComboBox comboBox;
        
        protected QLabel label_2;
        
        protected QComboBox comboBox_2;
        
        protected QCheckBox checkBox;
        
        protected QCheckBox checkBox_2;
        
        protected QGroupBox groupBox;
        
        protected QLabel label_3;
        
        protected QPushButton pushButton_4;
        
        protected QCheckBox checkBox_3;
        
        protected QCheckBox checkBox_4;
        
        protected QGroupBox groupBox_6;
        
        protected QComboBox comboBox_5;
        
        protected QLabel label_8;
        
        protected QGroupBox groupBox_2;
        
        protected QCheckBox checkBox_5;
        
        protected QWidget tab_7;
        
        protected QWidget tab_8;
        
        protected QWidget tab_3;
        
        protected QTableView extensionsList;
        
        protected QWidget widget_2;
        
        protected QPushButton pushButton_3;
        
        protected QWidget tab_6;
        
        protected QDialogButtonBox buttonBox;
        
        protected void SetupUi() {
            base.ObjectName = "PreferencesWindow";
            this.Geometry = new QRect(0, 0, 491, 491);
            this.WindowTitle = "Synapse Preferences";
            QVBoxLayout verticalLayout;
            verticalLayout = new QVBoxLayout(this);
            verticalLayout.Margin = 6;
            this.tabWidget = new QTabWidget(this);
            this.tabWidget.ObjectName = "tabWidget";
            this.tabWidget.CurrentIndex = 0;
            verticalLayout.AddWidget(this.tabWidget);
            this.tab = new QWidget(this.tabWidget);
            this.tab.ObjectName = "tab";
            QVBoxLayout verticalLayout_2;
            verticalLayout_2 = new QVBoxLayout(this.tab);
            verticalLayout_2.Spacing = 6;
            verticalLayout_2.Margin = 12;
            this.accountsList = new QTableView(this.tab);
            this.accountsList.ObjectName = "accountsList";
            this.accountsList.AlternatingRowColors = true;
            this.accountsList.selectionMode = QAbstractItemView.SelectionMode.SingleSelection;
            this.accountsList.selectionBehavior = QAbstractItemView.SelectionBehavior.SelectRows;
            this.accountsList.ShowGrid = false;
            this.accountsList.WordWrap = false;
            verticalLayout_2.AddWidget(this.accountsList);
            this.widget = new QWidget(this.tab);
            this.widget.ObjectName = "widget";
            QHBoxLayout horizontalLayout;
            horizontalLayout = new QHBoxLayout(this.widget);
            horizontalLayout.Margin = 0;
            this.addAccountButton = new QPushButton(this.widget);
            this.addAccountButton.ObjectName = "addAccountButton";
            this.addAccountButton.Enabled = true;
            this.addAccountButton.Text = "Add Account";
            horizontalLayout.AddWidget(this.addAccountButton);
            this.editAccountButton = new QPushButton(this.widget);
            this.editAccountButton.ObjectName = "editAccountButton";
            this.editAccountButton.Enabled = true;
            this.editAccountButton.Text = "Edit Account";
            horizontalLayout.AddWidget(this.editAccountButton);
            this.removeAccountButton = new QPushButton(this.widget);
            this.removeAccountButton.ObjectName = "removeAccountButton";
            this.removeAccountButton.Enabled = true;
            this.removeAccountButton.Text = "Remove Account";
            horizontalLayout.AddWidget(this.removeAccountButton);
            QSpacerItem horizontalSpacer;
            horizontalSpacer = new QSpacerItem(40, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
            horizontalLayout.AddItem(horizontalSpacer);
            verticalLayout_2.AddWidget(this.widget);
            this.tabWidget.AddTab(this.tab, "Accounts");
            this.tab_4 = new QWidget(this.tabWidget);
            this.tab_4.ObjectName = "tab_4";
            QVBoxLayout verticalLayout_6;
            verticalLayout_6 = new QVBoxLayout(this.tab_4);
            verticalLayout_6.Margin = 6;
            this.groupBox_5 = new QGroupBox(this.tab_4);
            this.groupBox_5.ObjectName = "groupBox_5";
            this.groupBox_5.Title = "Friends List";
            QFormLayout formLayout_2;
            formLayout_2 = new QFormLayout(this.groupBox_5);
            formLayout_2.Margin = 6;
            this.label_4 = new QLabel(this.groupBox_5);
            this.label_4.ObjectName = "label_4";
            this.label_4.Text = "Display As:";
            this.comboBox_3 = new QComboBox(this.groupBox_5);
            this.comboBox_3.ObjectName = "comboBox_3";
            QSizePolicy comboBox_3_sizePolicy;
            comboBox_3_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Preferred, QSizePolicy.Policy.Fixed);
            comboBox_3_sizePolicy.SetVerticalStretch(0);
            comboBox_3_sizePolicy.SetHorizontalStretch(0);
            comboBox_3_sizePolicy.SetHeightForWidth(this.comboBox_3.SizePolicy.HasHeightForWidth());
            this.comboBox_3.SizePolicy = comboBox_3_sizePolicy;
            formLayout_2.InsertRow(0, this.label_4, this.comboBox_3);
            this.horizontalSlider = new QSlider(this.groupBox_5);
            this.horizontalSlider.ObjectName = "horizontalSlider";
            QSizePolicy horizontalSlider_sizePolicy;
            horizontalSlider_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Fixed);
            horizontalSlider_sizePolicy.SetVerticalStretch(0);
            horizontalSlider_sizePolicy.SetHorizontalStretch(0);
            horizontalSlider_sizePolicy.SetHeightForWidth(this.horizontalSlider.SizePolicy.HasHeightForWidth());
            this.horizontalSlider.SizePolicy = horizontalSlider_sizePolicy;
            this.horizontalSlider.Maximum = 48;
            this.horizontalSlider.Value = 32;
            this.horizontalSlider.Orientation = Qt.Orientation.Horizontal;
            this.horizontalSlider.InvertedAppearance = false;
            this.horizontalSlider.InvertedControls = false;
            formLayout_2.InsertRow(2, this.label_5, this.horizontalSlider);
            this.comboBox_4 = new QComboBox(this.groupBox_5);
            this.comboBox_4.ObjectName = "comboBox_4";
            QSizePolicy comboBox_4_sizePolicy;
            comboBox_4_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Fixed);
            comboBox_4_sizePolicy.SetVerticalStretch(0);
            comboBox_4_sizePolicy.SetHorizontalStretch(0);
            comboBox_4_sizePolicy.SetHeightForWidth(this.comboBox_4.SizePolicy.HasHeightForWidth());
            this.comboBox_4.SizePolicy = comboBox_4_sizePolicy;
            formLayout_2.InsertRow(1, this.label_7, this.comboBox_4);
            this.label_7 = new QLabel(this.groupBox_5);
            this.label_7.ObjectName = "label_7";
            this.label_7.Text = "Sort By:";
            this.label_5 = new QLabel(this.groupBox_5);
            this.label_5.ObjectName = "label_5";
            this.label_5.Text = "Icon Size:";
            verticalLayout_6.AddWidget(this.groupBox_5);
            this.groupBox_4 = new QGroupBox(this.tab_4);
            this.groupBox_4.ObjectName = "groupBox_4";
            this.groupBox_4.Title = "Activity Feed";
            QGridLayout gridLayout_4;
            gridLayout_4 = new QGridLayout(this.groupBox_4);
            this.label_6 = new QLabel(this.groupBox_4);
            this.label_6.ObjectName = "label_6";
            this.label_6.Text = "Put options here";
            gridLayout_4.AddWidget(this.label_6, 0, 0, 1, 1);
            verticalLayout_6.AddWidget(this.groupBox_4);
            QSpacerItem verticalSpacer_3;
            verticalSpacer_3 = new QSpacerItem(20, 260, QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Expanding);
            verticalLayout_6.AddItem(verticalSpacer_3);
            this.tabWidget.AddTab(this.tab_4, "General");
            this.tab_5 = new QWidget(this.tabWidget);
            this.tab_5.ObjectName = "tab_5";
            QHBoxLayout horizontalLayout_3;
            horizontalLayout_3 = new QHBoxLayout(this.tab_5);
            horizontalLayout_3.Margin = 6;
            QVBoxLayout verticalLayout_4;
            verticalLayout_4 = new QVBoxLayout();
            horizontalLayout_3.AddLayout(verticalLayout_4);
            this.groupBox_3 = new QGroupBox(this.tab_5);
            this.groupBox_3.ObjectName = "groupBox_3";
            this.groupBox_3.Title = "Message Style";
            QFormLayout formLayout_3;
            formLayout_3 = new QFormLayout(this.groupBox_3);
            formLayout_3.Margin = 6;
            this.label = new QLabel(this.groupBox_3);
            this.label.ObjectName = "label";
            this.label.Text = "Message Style:";
            this.comboBox = new QComboBox(this.groupBox_3);
            this.comboBox.ObjectName = "comboBox";
            QSizePolicy comboBox_sizePolicy;
            comboBox_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed);
            comboBox_sizePolicy.SetVerticalStretch(0);
            comboBox_sizePolicy.SetHorizontalStretch(0);
            comboBox_sizePolicy.SetHeightForWidth(this.comboBox.SizePolicy.HasHeightForWidth());
            this.comboBox.SizePolicy = comboBox_sizePolicy;
            formLayout_3.InsertRow(0, this.label, this.comboBox);
            this.label_2 = new QLabel(this.groupBox_3);
            this.label_2.ObjectName = "label_2";
            this.label_2.Text = "Variant:";
            this.comboBox_2 = new QComboBox(this.groupBox_3);
            this.comboBox_2.ObjectName = "comboBox_2";
            QSizePolicy comboBox_2_sizePolicy;
            comboBox_2_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed);
            comboBox_2_sizePolicy.SetVerticalStretch(0);
            comboBox_2_sizePolicy.SetHorizontalStretch(0);
            comboBox_2_sizePolicy.SetHeightForWidth(this.comboBox_2.SizePolicy.HasHeightForWidth());
            this.comboBox_2.SizePolicy = comboBox_2_sizePolicy;
            formLayout_3.InsertRow(1, this.label_2, this.comboBox_2);
            this.checkBox = new QCheckBox(this.groupBox_3);
            this.checkBox.ObjectName = "checkBox";
            this.checkBox.Text = "Show avatars";
            this.checkBox.Checked = true;
            this.checkBox_2 = new QCheckBox(this.groupBox_3);
            this.checkBox_2.ObjectName = "checkBox_2";
            this.checkBox_2.Text = "Show header";
            this.checkBox_2.Checked = true;
            verticalLayout_4.AddWidget(this.groupBox_3);
            this.groupBox = new QGroupBox(this.tab_5);
            this.groupBox.ObjectName = "groupBox";
            this.groupBox.Title = "Text Display";
            QGridLayout gridLayout_2;
            gridLayout_2 = new QGridLayout(this.groupBox);
            gridLayout_2.Margin = 6;
            this.label_3 = new QLabel(this.groupBox);
            this.label_3.ObjectName = "label_3";
            this.label_3.Text = "Font:";
            gridLayout_2.AddWidget(this.label_3, 0, 0, 1, 1);
            this.pushButton_4 = new QPushButton(this.groupBox);
            this.pushButton_4.ObjectName = "pushButton_4";
            QSizePolicy pushButton_4_sizePolicy;
            pushButton_4_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed);
            pushButton_4_sizePolicy.SetVerticalStretch(0);
            pushButton_4_sizePolicy.SetHorizontalStretch(0);
            pushButton_4_sizePolicy.SetHeightForWidth(this.pushButton_4.SizePolicy.HasHeightForWidth());
            this.pushButton_4.SizePolicy = pushButton_4_sizePolicy;
            this.pushButton_4.Text = "(Set Font)";
            gridLayout_2.AddWidget(this.pushButton_4, 0, 1, 1, 1);
            this.checkBox_3 = new QCheckBox(this.groupBox);
            this.checkBox_3.ObjectName = "checkBox_3";
            this.checkBox_3.Text = "Show received message fonts";
            this.checkBox_3.Checked = true;
            gridLayout_2.AddWidget(this.checkBox_3, 1, 0, 1, 1);
            this.checkBox_4 = new QCheckBox(this.groupBox);
            this.checkBox_4.ObjectName = "checkBox_4";
            this.checkBox_4.Text = "Show received message colors";
            this.checkBox_4.Checked = true;
            gridLayout_2.AddWidget(this.checkBox_4, 2, 0, 1, 1);
            verticalLayout_4.AddWidget(this.groupBox);
            this.groupBox_6 = new QGroupBox(this.tab_5);
            this.groupBox_6.ObjectName = "groupBox_6";
            this.groupBox_6.Title = "Emoticons";
            QGridLayout gridLayout_6;
            gridLayout_6 = new QGridLayout(this.groupBox_6);
            gridLayout_6.Margin = 6;
            this.comboBox_5 = new QComboBox(this.groupBox_6);
            this.comboBox_5.ObjectName = "comboBox_5";
            QSizePolicy comboBox_5_sizePolicy;
            comboBox_5_sizePolicy = new QSizePolicy(QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Fixed);
            comboBox_5_sizePolicy.SetVerticalStretch(0);
            comboBox_5_sizePolicy.SetHorizontalStretch(0);
            comboBox_5_sizePolicy.SetHeightForWidth(this.comboBox_5.SizePolicy.HasHeightForWidth());
            this.comboBox_5.SizePolicy = comboBox_5_sizePolicy;
            gridLayout_6.AddWidget(this.comboBox_5, 0, 1, 1, 1);
            this.label_8 = new QLabel(this.groupBox_6);
            this.label_8.ObjectName = "label_8";
            this.label_8.Text = "Theme:";
            gridLayout_6.AddWidget(this.label_8, 0, 0, 1, 1);
            verticalLayout_4.AddWidget(this.groupBox_6);
            this.groupBox_2 = new QGroupBox(this.tab_5);
            this.groupBox_2.ObjectName = "groupBox_2";
            this.groupBox_2.Enabled = false;
            this.groupBox_2.Title = "Background";
            QGridLayout gridLayout_3;
            gridLayout_3 = new QGridLayout(this.groupBox_2);
            gridLayout_3.Margin = 6;
            this.checkBox_5 = new QCheckBox(this.groupBox_2);
            this.checkBox_5.ObjectName = "checkBox_5";
            this.checkBox_5.Text = "Use custom background";
            gridLayout_3.AddWidget(this.checkBox_5, 0, 0, 1, 1);
            verticalLayout_4.AddWidget(this.groupBox_2);
            QSpacerItem verticalSpacer;
            verticalSpacer = new QSpacerItem(268, 17, QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Expanding);
            verticalLayout_4.AddItem(verticalSpacer);
            this.tabWidget.AddTab(this.tab_5, "Chat");
            this.tab_7 = new QWidget(this.tabWidget);
            this.tab_7.ObjectName = "tab_7";
            this.tabWidget.AddTab(this.tab_7, "Status");
            this.tab_8 = new QWidget(this.tabWidget);
            this.tab_8.ObjectName = "tab_8";
            this.tabWidget.AddTab(this.tab_8, "Events");
            this.tab_3 = new QWidget(this.tabWidget);
            this.tab_3.ObjectName = "tab_3";
            QVBoxLayout verticalLayout_3;
            verticalLayout_3 = new QVBoxLayout(this.tab_3);
            verticalLayout_3.Spacing = 6;
            verticalLayout_3.Margin = 12;
            this.extensionsList = new QTableView(this.tab_3);
            this.extensionsList.ObjectName = "extensionsList";
            this.extensionsList.AlternatingRowColors = true;
            this.extensionsList.selectionMode = QAbstractItemView.SelectionMode.SingleSelection;
            this.extensionsList.selectionBehavior = QAbstractItemView.SelectionBehavior.SelectRows;
            this.extensionsList.ShowGrid = false;
            this.extensionsList.WordWrap = false;
            verticalLayout_3.AddWidget(this.extensionsList);
            this.widget_2 = new QWidget(this.tab_3);
            this.widget_2.ObjectName = "widget_2";
            QHBoxLayout horizontalLayout_2;
            horizontalLayout_2 = new QHBoxLayout(this.widget_2);
            horizontalLayout_2.Margin = 0;
            this.pushButton_3 = new QPushButton(this.widget_2);
            this.pushButton_3.ObjectName = "pushButton_3";
            this.pushButton_3.Enabled = false;
            this.pushButton_3.Text = "Find Updates";
            horizontalLayout_2.AddWidget(this.pushButton_3);
            QSpacerItem horizontalSpacer_2;
            horizontalSpacer_2 = new QSpacerItem(293, 20, QSizePolicy.Policy.Expanding, QSizePolicy.Policy.Minimum);
            horizontalLayout_2.AddItem(horizontalSpacer_2);
            verticalLayout_3.AddWidget(this.widget_2);
            this.tabWidget.AddTab(this.tab_3, "Extensions");
            this.tab_6 = new QWidget(this.tabWidget);
            this.tab_6.ObjectName = "tab_6";
            this.tabWidget.AddTab(this.tab_6, "Advanced");
            this.buttonBox = new QDialogButtonBox(this);
            this.buttonBox.ObjectName = "buttonBox";
            this.buttonBox.Orientation = Qt.Orientation.Horizontal;
            this.buttonBox.StandardButtons = global::Qyoto.Qyoto.GetCPPEnumValue("QDialogButtonBox", "Close");
            verticalLayout.AddWidget(this.buttonBox);
            QObject.Connect(buttonBox, Qt.SIGNAL("rejected()"), this, Qt.SLOT("close()"));
            QObject.Connect(buttonBox, Qt.SIGNAL("accepted()"), this, Qt.SLOT("close()"));
            QMetaObject.ConnectSlotsByName(this);
        }
    }
}
