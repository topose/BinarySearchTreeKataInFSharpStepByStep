namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        match this with
        | EmptyTree -> BinaryTree(value, EmptyTree, EmptyTree)
        | BinaryTree (root, left, right) -> 
            BinaryTree(root, EmptyTree.Insert(value), EmptyTree)
        

    member this.InOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, EmptyTree, EmptyTree) -> [value]
        | BinaryTree (value, BinaryTree(left_value, EmptyTree, EmptyTree), EmptyTree) -> 
            [left_value] @ [value]
        | BinaryTree (value, left, right) -> []