--require "luanet"
luanet.load_assembly("System")
Int32 = luanet.import_type("System.Int32")--Int32�ǽṹ��
print(Int32)
---ʵ����CLR����
num=Int32.Parse("466")
print(num)

luanet.load_assembly("TestLuaInterface")
Program = luanet.import_type("TestLuaInterface.Program")

init=Program() --���캯��
print(init.name)
init:Method()
print(init:Out("xxxx")) --out������ֵҲ�����,��������,�����out����ֵ
print(init:Ref("xxxx",4)) --ref������ֵҲ�����,��������,�����ref����ֵ

