using System;
using System.Collections.Generic;

class BinaryTree
{
	// atributos
	private	TreeNode root;

    public BinaryTree() 
    {
		this.root = null;
	}

    // Verifica se arvore está vazia
    public bool IsEmpty() {
		return this.root == null;
	} 

    // Insert
    public void Insert (Table data) 
    {
        this.Insert(new TreeNode(data));
    }

    public void Insert (TreeNode node) 
    {
        if (this.IsEmpty()) {
            this.InsertRoot(node);
        } else {
            this.InsertNode(node);
        }
    }

    private void InsertRoot( TreeNode newNode) 
    {
        this.root = newNode;
    }

    private void InsertNode (TreeNode newNode) 
    {
        var father = this.SearchFather(newNode);
        if ( father.Compare(newNode) < 0) {
            father.Left(newNode);
        } else {
            father.Right(newNode);
        }
    }

    // Contar
    private int prepareCont() 
    {
        var node = new Stack<TreeNode>();
        node.Push(this.root);

        return this.Contar(node, 0);
    }

    public int Cont() 
    {
        return this.IsEmpty()? 0: this.prepareCont();
    }

    private int Contar(Stack<TreeNode> nodes, int contagem) 
    {
		while( nodes.Count != 0 ) {
			TreeNode node = nodes.Pop();
			contagem ++;

			if( node.TryLeft() ) nodes.Push(node.Left());
			if( node.TryRight()  ) nodes.Push(node.Right() );
		}
		return contagem;
	}

    // Search

    public TreeNode Search (string element) 
    {
        return this.IsEmpty()?
			null:
			this.buscar(element);
    }

    private TreeNode SearchFather (TreeNode newNode) 
    {
        TreeNode actual = this.root;
		var nextnode  = newNode.RootAssume(actual);

		while( nextnode != null ) 
        {
			actual = nextnode;
			nextnode = newNode.RootAssume(actual);
		}
		return actual;
    }

    TreeNode buscar( string idSearched ) 
    {
		var ActualNode = this.root;

		while(  ActualNode != null  ) {
			if( ActualNode.ID().Equals(idSearched) ) break;
			ActualNode = ActualNode.NextNode(idSearched);
		}
		return ActualNode;
	}

    private TreeNode SearchFatherOf( TreeNode node ) {
		var actualNode = this.root;
		var next = actualNode.NextNode(node);

		while( next != node ) {
			actualNode = next;
			next = actualNode.NextNode(node);
		}
		return actualNode;
	}

    // Delete
    public Table Delete( string element)
    {
		var node = this.Search(element);
		return node != null?
			this.remover(node):
			null;
	}

    private Table remover( TreeNode node ) 
    {

		switch( node.HowManySons() ) {
			case 0: this.RemoveFolha(node);     break;
			case 1: this.RemovePaiDeUm(node);   break;
			case 2: this.RemovePaiDeDois(node); break;
		}
		return node.Data();
	}

    private void RemoveRoot() {
		this.root = null;
	} 

    private void RemoveFolha( TreeNode node ) {
		if( node == this.root ) {
            this.RemoveRoot();
        } else {  this.removeFolha(node); }
	}

    private void removeFolha( TreeNode node ) {
		var father = SearchFatherOf(node);

		if( father.Left() == node ) {
			father.Left(null);
		} else father.Right(null);
	} 

    private void RemovePaiDeUm( TreeNode node ) {
		if( node == this.root ) this.RemoveRootOne();
		else                  this.removePaiDeUm(node);
	}

    private void RemoveRootOne() {
		if( this.root.TryLeft() )
			this.root  = this.root.Left();
		else this.root = this.root.Right();
	}

    private void removePaiDeUm( TreeNode node ) {
		var father   = SearchFatherOf(node);
		var son = node.TryRight()?
			node.Right():
		 	node.Left();

		if( father.Left() == node) {
			father.Left(son);
        } else { father.Right(son); }
	}

    private void RemovePaiDeDois( TreeNode removido ) {
		var nodeSubs   = removido.BeforeNode();
		var fatherSubs = this.SearchFatherOf(nodeSubs);

		if( fatherSubs.Left() == nodeSubs ) {
			fatherSubs.Left(null);
		} else fatherSubs.Right(null);

		nodeSubs.Left( removido.Left());
		nodeSubs.Right ( removido.Right ());

		if( removido != this.root ) {
			var fatherNodeRemoved = this.SearchFatherOf(removido);
			if( fatherNodeRemoved.Left() == removido ) {
				fatherNodeRemoved.Left(nodeSubs);
			} else fatherNodeRemoved.Right(nodeSubs);
		} else this.root = nodeSubs;

		removido.Left(null);
		removido.Right (null);
	}

    
    
}