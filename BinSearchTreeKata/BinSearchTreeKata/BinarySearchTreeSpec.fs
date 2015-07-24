module BinarySearchTreeSpec

open System
open BinarySearchTreeKata

open Xunit
open Xunit.Abstractions

[<Fact>]
let ``Create a tree with just a root`` () =
    let sut = EmptyTree.Insert(4)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([4], sut.InOrder)
    Assert.Equal<Collections.Generic.IEnumerable<int>>([4], sut.PreOrder)


[<Fact>]
let ``Create a tree with root, left and right son`` () =
    let sut = EmptyTree.Insert(4).Insert(1).Insert(5)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([1; 4; 5], sut.InOrder)
    Assert.Equal<Collections.Generic.IEnumerable<int>>([4; 1; 5], sut.PreOrder)

[<Fact>]
let ``Create a complex tree`` () =
    let sut = EmptyTree.Insert(4).Insert(2).Insert(6).Insert(3).Insert(1).Insert(5).Insert(7)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([1; 2; 3; 4; 5; 6; 7], sut.InOrder)
    Assert.Equal<Collections.Generic.IEnumerable<int>>([4; 2; 1; 3; 6; 5; 7], sut.PreOrder)