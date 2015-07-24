namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        match this with
        | EmptyTree -> BinaryTree(value, EmptyTree, EmptyTree)
        | BinaryTree (root, left, right) as node -> 
            if (value < root) then
                BinaryTree(root, EmptyTree.Insert(value), right)
            elif (value > root) then
                BinaryTree(root, left, EmptyTree.Insert(value))
            else
                node

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