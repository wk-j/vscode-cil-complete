## IL Syntax and Snippets

## Installation

> `ext install vscode-cil-complete`

## Snippets

- prog (New program)
- pubc (Public class)
- pric (Private class)
- pubm (Public method)
- prim (Private method)

## Sample

```javascript
prog<tab>
```

## Result

```csharp
.assembly extern mscorlib {}
.assembly 'App' {}
.class private auto ansi beforefieldinit Program extends [mscorlib]System.Object {
    .method private hidebysig static void Main ( string[] args) cil managed {
        .entrypoint
        
        ret
    }
    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed {
        ldarg.0
        call instance void [mscorlib]System.Object::.ctor()
        ret
    }
} 
```