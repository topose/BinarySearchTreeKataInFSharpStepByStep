namespace BinarySearchTreeKata

type BinarySearchTree = 
    | EmptyTree
    | BinaryTree of int * BinarySearchTree * BinarySearchTree

    member this.Insert(value:int) = 
        match this with
        | EmptyTree -> BinaryTree(value, EmptyTree, EmptyTree)
        | BinaryTree (rootValue, leftTree, rightTree) as root -> 
            if (value < rootValue) then
                BinaryTree(rootValue, leftTree.Insert(value), rightTree)
            elif (value > rootValue) then
                BinaryTree(rootValue, leftTree, rightTree.Insert(value))
            else
                root

    member this.FromList(values:int list) = 
        match values with
        | head :: tail -> this.Insert(head).FromList(tail)
        | [] -> this

    member this.InOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, leftTree, rightTree) -> 
            leftTree.InOrder @ [value] @ rightTree.InOrder

    member this.PreOrder =
        match this with
        | EmptyTree -> []
        | BinaryTree (value, leftTree, rightTree) -> 
            [value] @ leftTree.PreOrder @ rightTree.PreOrder