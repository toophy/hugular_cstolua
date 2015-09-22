﻿using System;
using UnityEngine;
using LuaInterface;
using Object = UnityEngine.Object;

public class BillboardRendererWrap
{
	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[]
		{
			new LuaMethod("New", _CreateBillboardRenderer),
			new LuaMethod("GetClassType", GetClassType),
			new LuaMethod("__eq", Lua_Eq),
		};

		LuaField[] fields = new LuaField[]
		{
			new LuaField("billboard", get_billboard, set_billboard),
		};

		LuaScriptMgr.RegisterLib(L, "UnityEngine.BillboardRenderer", typeof(BillboardRenderer), regs, fields, typeof(Renderer));
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBillboardRenderer(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 0)
		{
			BillboardRenderer obj = new BillboardRenderer();
			LuaScriptMgr.Push(L, obj);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: BillboardRenderer.New");
		}

		return 0;
	}

	static Type classType = typeof(BillboardRenderer);

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_billboard(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardRenderer obj = (BillboardRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name billboard");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index billboard on a nil value");
			}
		}

		LuaScriptMgr.Push(L, obj.billboard);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_billboard(IntPtr L)
	{
		object o = LuaScriptMgr.GetLuaObject(L, 1);
		BillboardRenderer obj = (BillboardRenderer)o;

		if (obj == null)
		{
			LuaTypes types = LuaDLL.lua_type(L, 1);

			if (types == LuaTypes.LUA_TTABLE)
			{
				LuaDLL.luaL_error(L, "unknown member name billboard");
			}
			else
			{
				LuaDLL.luaL_error(L, "attempt to index billboard on a nil value");
			}
		}

		obj.billboard = (BillboardAsset)LuaScriptMgr.GetUnityObject(L, 3, typeof(BillboardAsset));
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		Object arg0 = LuaScriptMgr.GetLuaObject(L, 1) as Object;
		Object arg1 = LuaScriptMgr.GetLuaObject(L, 2) as Object;
		bool o = arg0 == arg1;
		LuaScriptMgr.Push(L, o);
		return 1;
	}
}
