namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        match this with
        | EmptyTree -> BinaryTree(value, EmptyTree, EmptyTree)
        | BinaryTree (root_value, left, right) as root -> 
            if (value < root_value) then
                BinaryTree(root_value, EmptyTree.Insert(value), right)
            elif (value > root_value) then
                BinaryTree(root_value, left, EmptyTree.Insert(value))
            else
                root

    member this.InOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, EmptyTree, EmptyTree) -> [value]
        | BinaryTree (value, BinaryTree(left_value, EmptyTree, EmptyTree), EmptyTree) -> 
            [left_value] @ [value]
        | BinaryTree (value, EmptyTree, BinaryTree(right_value, EmptyTree, EmptyTree)) -> 
            [value] @ [right_value] 
        | BinaryTree (value, BinaryTree(left_value, EmptyTree, EmptyTree), BinaryTree(right_value, EmptyTree, EmptyTree)) -> 
            [left_value] @ [value] @ [right_value] 
        | BinaryTree (value, left, right) -> []