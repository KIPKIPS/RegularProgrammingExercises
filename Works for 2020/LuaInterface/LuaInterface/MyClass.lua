--require "luanet"
luanet.load_assembly("System")
Int32 = luanet.import_type("System.Int32")--Int32是结构体
print(Int32)
---实例化CLR对象
num=Int32.Parse("466")
print(num)

luanet.load_assembly("TestLuaInterface")
Program = luanet.import_type("TestLuaInterface.Program")

init=Program() --构造函数
print(init.name)
init:Method()
print(init:Out("xxxx")) --out参数的值也会输出,先输出结果,再输出out参数值
print(init:Ref("xxxx",4)) --ref参数的值也会输出,先输出结果,再输出ref参数值

