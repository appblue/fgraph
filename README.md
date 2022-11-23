# fgraph

Simple DAG Algorithms in FSharp. To run execute the following command:

```shell
$ dotnet run
```
You should get following result:

```
graph: [(1, 2); (2, 3); (2, 4); (3, 1); (6, 5); (5, 4)] 
query: [(1, 4); (1, 5); (1, 3)] 
result: [true; false; true] 

```