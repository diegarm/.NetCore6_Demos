# __Visual Studio Regular Expressions__

### __How to use?__
Apply the following __Strings__ as a regular expression search on Visual Studio

![image.png](/.attachments/image-aef633ed-5e90-4bc4-b2a3-c3b4760da752.png)

### __How to find out nullable properties being assigned a null-forgiving operator?__
`public\s+\w+\?+\s+\w+\s*{\s*get;\s*set;\s*}\s*=\s*null!;`

### __How to find out all invocations of a method using X or more arguments?__
`MethodNameAsync\s*\(\s*[^,\s]+(\s*,\s*[^,\s]+){X,}\s*\)` 
__X__ = {0, 1, ..., 999}
**MethodNameAsync** can be replaced by the method's name.

### __How to find out all invocations of a method using Y to Z arguments?__
`MethodNameAsync\s*\(\s*([^,\s]+(\s*,\s*[^,\s]+){Y,Z})?\s*\)` 
__Y__ = {0, 1, ..., 999}
__Z__ = **Y** + {0, 1, ..., 999}
**MethodNameAsync** can be replaced by the method's name.