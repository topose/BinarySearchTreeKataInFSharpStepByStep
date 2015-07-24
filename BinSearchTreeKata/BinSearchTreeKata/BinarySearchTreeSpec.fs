module BinarySearchTreeSpec

open System
open BinarySearchTreeKata

open Xunit
open Xunit.Abstractions

[<Fact>]
let ``Create a tree with just a root`` () =
    let sut = EmptyTree.FromList([4])

    Assert.Equal<int list>([4], sut.InOrder)
    Assert.Equal<int list>([4], sut.PreOrder)


[<Fact>]
let ``Create a tree with root, left and right son`` () =
    let sut = EmptyTree.FromList([4; 1; 5])

    Assert.Equal<int list>([1; 4; 5], sut.InOrder)
    Assert.Equal<int list>([4; 1; 5], sut.PreOrder)

[<Fact>]
let ``Create a complex tree`` () =
    let sut = EmptyTree.FromList([4; 2; 6; 3; 1; 5; 7])

    Assert.Equal<int list>([1; 2; 3; 4; 5; 6; 7], sut.InOrder)
    Assert.Equal<int list>([4; 2; 1; 3; 6; 5; 7], sut.PreOrder)