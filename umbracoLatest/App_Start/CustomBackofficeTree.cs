using System.Text;

using umbraco.businesslogic;
using umbraco.cms.presentation.Trees;

namespace UmbracoLatest.App_Start
{
    [Tree("customBackoffice", "customBackoffice_GetUsers", "GetUsers", ".sprTreeFolder", "sprTreeFolder_o")]
    public class CustomBackofficeTree : BaseTree
    {
        public CustomBackofficeTree(string application)
            : base(application)
        {
        }

        public override void RenderJS(ref StringBuilder javascript)
        {
            javascript.Append(@"
            function openSendNewsletter() {
            parent.right.document.location.href = 'newsletter/sendNewsletter.aspx';
            }
            ");

            javascript.Append(@"
            function openPreviousNewsletters() {
            parent.right.document.location.href = 'newsletter/previousNewsletters.aspx';
            }
            ");
        }

        public override void Render(ref XmlTree tree)
        {
            // Create tree node to allow sending a newsletter
            var sendNewsletter = XmlTreeNode.Create(this);
            sendNewsletter.Text = "Send Newsletter";
            sendNewsletter.Icon = "VisualStudio.gif";
            sendNewsletter.Action = "javascript:openSendNewsletter()";
            
            // Add the node to the tree
            tree.Add(sendNewsletter);

            // Create tree node to allow viewing previously sent newsletters
            var previousNewsletters = XmlTreeNode.Create(this);
            previousNewsletters.Text = "Previous Newsletters";
            previousNewsletters.Icon = "docPic.gif";
            previousNewsletters.Action = "javascript:openPreviousNewsletters()";
            
            // Add the node to the tree
            tree.Add(previousNewsletters);
        }

        protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {
            rootNode.Icon = FolderIcon;
            rootNode.OpenIcon = FolderIconOpen;
            rootNode.NodeType = "init" + TreeAlias;
            rootNode.NodeID = "init";
        }
    }

}