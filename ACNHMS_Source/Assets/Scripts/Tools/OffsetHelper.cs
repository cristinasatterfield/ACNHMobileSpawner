﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OffsetHelper
{
    // some helpers
    public const ulong PlayerSize = 0x133B78;
    public const ulong PlayerOtherStartPadding = 0x36A50;

    // player other (Personal Offsets 13)
    public const ulong InventoryOffset = 0xAD3C7FD8; // player 0 (A)
    private const ulong playerOtherStart = InventoryOffset - 0x10; // helps to get other values, unused 

    public const ulong WalletAddress = InventoryOffset + 0xB8;
    public const ulong MilesAddress = InventoryOffset - 0x25590;
    public const ulong BankAddress = InventoryOffset + 0x3517C;

    // main player offsets functions
    private static ulong getPlayerStart(ulong invOffset) => invOffset - 0x10 - PlayerOtherStartPadding + 0x110;
    public static ulong getPlayerIdAddress(ulong invOffset) => getPlayerStart(invOffset) + 0xAFA8;
    public static ulong getPlayerProfileMainAddress(ulong invOffset) => getPlayerStart(invOffset) + 0x116A0;
    public static ulong getManpu(ulong invOffset) => invOffset - 0x10 + 0xAF7C + 72;


    // main save offsets
    public const ulong TurnipAddress = 0xABE0AEE0;
    public const ulong VillagerAddress = TurnipAddress - 0x41D460 + 0x10;
    public const ulong VillagerHouseAddress = TurnipAddress - 0x41D460 + 0x419638;
    public const ulong BackupSaveDiff = 0xB25900;

    public const ulong ArriverNameListAddress = 0xA97CC3C;
    public const ulong ArriverNameLocAddress = 0xB694A4A8;
    public const ulong LeaverNameListAddress = 0x4D09B608;
    public const ulong LeaverNameLocAddress = 0xB6A7E420;

    public const ulong DodoAddress = 0xA97D0F4;

    public const ulong FieldItemStart = VillagerAddress - 0x10 + 0x20CC0C;
    public const ulong LandMakingMapStart = FieldItemStart + 0xAAA00;
    public const ulong OutsideFieldStart = FieldItemStart + 0xCF998;
    public const ulong MainFieldStructurStart = FieldItemStart + 0xCF600;
}
