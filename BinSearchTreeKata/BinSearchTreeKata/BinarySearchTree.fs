namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        match this with
        | EmptyTree -> BinaryTree(value, EmptyTree, EmptyTree)
        | BinaryTree (root_value, left, right) as root -> 
            if (value < root_value) then
                BinaryTree(root_value, left.Insert(value), right)
            elif (value > root_value) then
                BinaryTree(root_value, left, right.Insert(value))
            else
                root

    member this.InOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, left, right) -> 
            left.InOrder @ [value] @ right.InOrder

    member this.PreOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, left, right) -> 
            [value] @ left.PreOrder @ right.PreOrder