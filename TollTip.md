1. Component      
Inactive / Active Status                         
Name
Changed at: CR code 
sop: Sop Number
changed at: DateTime
Modified by: userName

Later changed in:   CR 
                    Sop
                    Changed at:
                    CHANGED AUTHOR
 latest changed?

Inactive reasoning: (sync as Status reasoning both for Inactive and active)


2. AE (same as Component)
3.Signal ()

Component > AC Compresor Solenoid Valve 
Broadcase?yellow 

why tooltip is not applied to all components /AE 


1. MessageBox: 
* add "Inactive reasoning" once in case that All AE ports are inactive 
* if it is a dynamic layout: 
all ports are inactive > inactive Msbox. 
if any of link is active > active msbox 

for staic layout:
all ports are active > active box 
if any of ports is incative > Inactive box

we have a box which is active with some inactive ports not all 

ctrl+ c //comments selected lines
ctrl + k //cancel comments 



### add ComponentCodeNode in NavTree
GetRelatedUserFunctions: in Graph.cs. It will get related User functions for Aeports and vice versa

* For AED: list all AED as its childs
* User Category: UC > subfolders with all UCs. > expand one UC it will show all related UFs. > So expand UF, it will list all its related folders(nodes): AED, FC, AE, Component ... 

* User Functions: > expand to get all its UFs. > expand one UF gets all its related nodes : AED, FC, AE, Component ... 

* ComponentNode: expand ComponentNode> list all componentNodes> expand one Node, it will list all its related Component (one code for one component? eller one code could be several Component?), expand one component, it will show components related nodes (Connected Can and its component Name.)


is this one mapping to navTree node name: FunctionCategoryListControl < Function Categories>

what we use to visualize this tree and folder . not like tables and grids using xaml ?     public partial class InstancesTreeView :


FolderTreeNode.cs > we use this to get all TreeNode name but where we set its name?  Entity Name? yes All these Tree Nodes are Entity Type. 

We use Entity frame work to build the Navigate tree + 

* ? how we use Entity framework + xaml + c# to build navigate tree? 

we need to add ComponentCode => Component  as parent node of Component
Similar as 


using TreeNode = SesammTool2.PresentationLayer.Tree.TreeNode;
namespace SesammTool2.PresentationLayer.Modules.NavigationTreeModule
NavigationTreeList
ListViewType.cs
treeListNavigators
InstanceTreeViewModels,cs
InstanceTreeView.xaml
NavigatonTreeList.xmal
NavigationTreeBuilde.cs
NavigationTreeManuManagers.cs
TypeFolderTreeNode.cs
ValueTableTreeNode.cs
TreeNode.cs
FolderTreeNode.cs
InstanceNode.cs
VavigationTreeviewMODELS.CS
EntityTypeListControlMapping !!!!!!!****
adaptiveListControl
TreeNodeContextMenu
NavigationTreeModule!!! switch nodes

1. click Segment expand => ACSSubCAN1 
   NavigationTreeBuilder => ViewModel.async Task LoadNode InstanceNode

   2. ComponentCode => Component
   Similar as CanSignal => CanMessage TreeNode 


get CanMessageInstanceChilden/adress childern>      result.AddRange(EntityPresenter.FolderTypes.Select(t => CreateFolderNodeWithDirectionalSubfolders(parent, t, showCount, nodeList.Where(n => n.Instance.EntityType == t), expandedState)).Where(f => f != null).ToList());
            }

            result = result.OrderBy(e => EnumExtensions.GetLogicalListPosition(e.Name)).ToList();
            return result;

             public override object Value => _func != null ? _func(Instance) : Instance.GetProperty(PropertyName); EMpty ! 

             HOW DOES CanMessageNode added under Cansignal Node


CreateFolderNodeWithDirectionalSubfolders: will create parentTreeNodes with its all instanceNodes
1. CanSignals: list all Cansignal as instance nodes.it will count this folderType: Cansignlas have how many instances as nodes.
   how did it count or get?  take CanSignal as example, it will call CanSignal.ToInstanceType return type
   ModelInfo.Relations[entityType.CanSignal].InterfaceType; > Relations is a dictionary
   Relation[EntityType] > return values as ModelReLation which is class 

    > u15signal: 
graph.GetNods should get some nodes >>
folder u15Signal (InstanceNodefolder) is created by DirectionalTypeFolderTreeNode 
then we need to add related childer under it. 
how do we add CANMessage ( Cansignal.AnchorKey = CanmessageSignalAnhor.CansignalKey > CanMessage.AnchorkEY but we add CanMessageNode not just instance)

it will add instanceNode as its childen not only instance itself. Node means includes relations. 
AddChildren(IEnumerable<TreeNode> treeNodes) takes list Inumerable list as params: createInstanceNode returns > enumerable Nodes
createInstanceNode uses: GetInstanceChildren(InstanceNode instanceNode, HashSet<string> expandedState

before we get u15Signal its childern node(Can Message) we need to get its direct parentNode which is Cansignlas.. then get its realted graph
for exaple this Cansignals as pareant Instace then get all its realted 
GetRelatedGraph(IEnumerable<IDirectionalInstance> parentInstances)