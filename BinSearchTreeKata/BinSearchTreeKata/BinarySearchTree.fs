namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        BinaryTree(value, EmptyTree, EmptyTree)

    member this.InOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, EmptyTree, EmptyTree) -> [value]
        | BinaryTree (value, left, right) -> []