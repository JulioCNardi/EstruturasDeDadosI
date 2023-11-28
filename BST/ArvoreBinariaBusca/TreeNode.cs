using System;

class TreeNode
{
    private TreeNode left;
	private TreeNode right;
	private Table data;

    public TreeNode(Table data) 
	{
		this.left = null;
		this.right  = null;
		this.data    = data;
	}

	// Métodos Abertos
	public TreeNode RootAssume(TreeNode father) 
	{
		return father.Compare(this) < 0? father.left:father.right;
	} 

	public int Compare(TreeNode node) 
	{
		string father = this.ID();
		string son = node.ID();
		return String.Compare(father, son);
	}

	public TreeNode NextNode( string id ) 
	{
		var idFather = this.ID();
		return String.Compare(idFather, id) < 0? this.left: this.right;
	} 

	public TreeNode NextNode( TreeNode node ) 
	{
		return this.NextNode(node.ID());
	} 

	public int HowManySons()
	{
		var left = Convert.ToInt32(this.TryLeft());
		var right  = Convert.ToInt32(this.TryRight() );
		return left + right;
	} 

	public TreeNode BeforeNode() 
	{
		var ActualNode = this.left;
		while (ActualNode.TryRight()) 
			ActualNode = ActualNode.right;
		return ActualNode; 
	}



	// Métodos padrão Left

	// GET
	public TreeNode Left() {
		return this.left;
	} 
	// SET
	public void  Left(TreeNode left) {
		 this.left = left;
	} 
	// Try Hash
	public bool  TryLeft() {
		 return this.left != null;
	} 

	// Métodos padrão Right

	// GET
	public TreeNode Right() {
		return this.right;
	} 
	// SET
	public void Right(TreeNode right) {
		 this.right = right;
	} 
	// Try Hash
	public bool  TryRight() {
		 return this.right != null;
	} 

	// Métodos padrão Data e ID

	public Table Data() {
		return this.data;
	} // fim (get/Obter) dados

	public string ID() {
		return (this.data).IdSearch();
	} // fim (get/Obter) id

}

