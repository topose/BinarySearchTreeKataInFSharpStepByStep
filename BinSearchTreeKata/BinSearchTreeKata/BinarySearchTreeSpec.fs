module BinarySearchTreeSpec

open System
open BinarySearchTreeKata

open Xunit
open Xunit.Abstractions

[<Fact>]
let ``Create a tree with just a root`` () =
    let sut = EmptyTree.Insert(4)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([4], sut.InOrder)

[<Fact>]
let ``Create a tree with root, left and right son`` () =
    let sut = EmptyTree.Insert(4).Insert(1).Insert(5)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([1; 4; 5], sut.InOrder)