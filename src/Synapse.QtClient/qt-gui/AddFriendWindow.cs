// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using Qyoto;


public partial class AddFriendWindow : QWidget {
    
    protected QLabel label_2;
    
    protected QLabel label;
    
    protected QLineEdit lineEdit;
    
    protected Synapse.QtClient.Widgets.EditGroupsWidget groupsWidget;
    
    protected QDialogButtonBox buttonBox;
    
    protected void SetupUi() {
        base.ObjectName = "AddFriendWindow";
        this.Geometry = new QRect(0, 0, 237, 252);
        this.WindowTitle = "AddFriend";
        QVBoxLayout verticalLayout;
        verticalLayout = new QVBoxLayout(this);
        verticalLayout.Margin = 6;
        QSpacerItem verticalSpacer_2;
        verticalSpacer_2 = new QSpacerItem(20, 40, QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Expanding);
        verticalLayout.AddItem(verticalSpacer_2);
        this.label_2 = new QLabel(this);
        this.label_2.ObjectName = "label_2";
        this.label_2.Text = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0//EN\" \"http://www.w3.org/TR/REC-html40/strict.dtd\">\n<html><head><meta name=\"qrichtext\" content=\"1\" /><style type=\"text/css\">\np, li { white-space: pre-wrap; }\n</style></head><body style=\" font-family:'DejaVu Sans'; font-size:9pt; font-weight:400; font-style:normal;\">\n<p style=\" margin-top:0px; margin-bottom:0px; margin-left:0px; margin-right:0px; -qt-block-indent:0; text-indent:0px;\"><span style=\" font-weight:600;\">Add Friend</span></p></body></html>";
        verticalLayout.AddWidget(this.label_2);
        QGridLayout gridLayout;
        gridLayout = new QGridLayout();
        verticalLayout.AddLayout(gridLayout);
        this.label = new QLabel(this);
        this.label.ObjectName = "label";
        this.label.Text = "JID:";
        gridLayout.AddWidget(this.label, 0, 0, 1, 1);
        this.lineEdit = new QLineEdit(this);
        this.lineEdit.ObjectName = "lineEdit";
        gridLayout.AddWidget(this.lineEdit, 0, 1, 1, 1);
        this.groupsWidget = new Synapse.QtClient.Widgets.EditGroupsWidget(this);
        this.groupsWidget.ObjectName = "groupsWidget";
        verticalLayout.AddWidget(this.groupsWidget);
        this.buttonBox = new QDialogButtonBox(this);
        this.buttonBox.ObjectName = "buttonBox";
        this.buttonBox.StandardButtons = global::Qyoto.Qyoto.GetCPPEnumValue("QDialogButtonBox", "NoButton");
        verticalLayout.AddWidget(this.buttonBox);
        QSpacerItem verticalSpacer;
        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy.Policy.Minimum, QSizePolicy.Policy.Expanding);
        verticalLayout.AddItem(verticalSpacer);
        QMetaObject.ConnectSlotsByName(this);
    }
}
