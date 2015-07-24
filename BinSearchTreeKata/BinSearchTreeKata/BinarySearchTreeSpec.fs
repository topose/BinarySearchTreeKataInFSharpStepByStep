﻿module BinarySearchTreeSpec

open System
open BinarySearchTreeKata

open Xunit
open Xunit.Abstractions

[<Fact>]
let ``Create a tree with just a root`` () =
    let sut = EmptyTree.Insert(4)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([4], sut.InOrder)

[<Fact>]
let ``Create a tree with just root and left son`` () =
    let sut = EmptyTree.Insert(4).Insert(1)

    Assert.Equal<Collections.Generic.IEnumerable<int>>([1; 4], sut.InOrder)