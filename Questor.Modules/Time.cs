﻿// ------------------------------------------------------------------------------
//   <copyright from='2010' to='2015' company='THEHACKERWITHIN.COM'>
//     Copyright (c) TheHackerWithin.COM. All Rights Reserved.
// 
//     Please look in the accompanying license.htm file for the license that 
//     applies to this source code. (a copy can also be found at: 
//     http://www.thehackerwithin.com/license.htm)
//   </copyright>
// -------------------------------------------------------------------------------
namespace Questor.Modules
{
    public enum Time
    {
        QuestorPulse_milliseconds = 1000,                         // Used to delay the next pulse, units: milliseconds. Default is 1500
        DefenceDelay_milliseconds = 500,
        AfterburnerDelay_milliseconds = 1000,
        RepModuleDelay_milliseconds = 1000,
        ApproachDelay_seconds = 2,
        TargetDelay_miliseconds = 1000,
        WeaponDelay_miliseconds = 220,
        NosDelay_miliseconds = 220,
        WebDelay_miliseconds = 220,
        PainterDelay_miliseconds = 220,
        ValidateSettings_seconds = 15,                           // This is the delay between character settings validation attempts. The settings will be reloaded at this interval if they have changed. Default is 15
        SetupLogPathDelay_seconds = 10,                          // Why is this delay here? this can likely be removed with some testing... Default is 10
        SessionRunningTimeUpdate_seconds = 15,                   // This is used to update the session running time counter every x seconds: default is 15 seconds
        WalletCheck_minutes = 1,                                 // Used to delay the next wallet balance check, units: minutes. Default is 1
        DelayedGotoBase_seconds = 15,                            // Delay before going back to base, usually after a disconnect / reconnect. units: seconds. Default is 15
        WaitforBadGuytoGoAway_minutes = 5,                       // Stay docked for this amount of time before checking local again, units: minutes. Default is 5
        CloseQuestorDelayBeforeExit_seconds = 20,                // Delay before closing eve, units: seconds. Default is 20
        QuestorBeforeLoginPulseDelay_milliseconds = 20,          // Pulse Delay for Program.cs: Used to control the speed at which the program will retry logging in and retry checking the schedule
        SwitchShipsDelay_seconds = 10,                           // Switch Ships Delay before retrying, units: seconds. Default is 10
        SwitchShipsCheck_seconds = 7,                            // Switch Ships Check to see if ship is correct, units: seconds. Default is 7
        FittingWindowLoadFittingDelay_seconds = 10,              // We can ask the fitting to be loaded using the fitting window, but we cant know it is done, thus this delay, units: seconds. Default is 10
        Armstate_WaitforItemstoMove_seconds = 5,                 // Arm state: wait for items to move, units: seconds. Default is 5
        LocalWatch_CheckLocalDelay_seconds = 5,                  // Local Check for bad standings pilots, delay between checks, units: seconds. Default is 5
        ReloadWeaponDelayBeforeUsable_seconds = 22,              // Delay after reloading before that module is usable again (non-energy weapons), units: seconds. Default is 22
        BookmarkPocketRetryDelay_seconds = 20,                   // When checking to see if a bookmark needs to be made in a pocket for after mission salvaging this is the delay between retries, units: seconds. Default is 20
        ActivateAction_NoGateFound_delay = 30,                   // no gate found on grid when executing the activate action, wait this long to see if it appears (lag), units: seconds. Default is 30
        LastAlignDelay_minutes = 2,                              // Delay between the last align command and the next, units: minutes. Default is 2 
        DelayBetweenJetcans_seconds = 185,                       // Once you have made a jetcan you cannot make another for 3 minutes, units: seconds. Default is 185 (to account for lag)
        SalvageStackItemsDelayBeforeResuming_seconds = 5,        // When stacking items in cargohold delay before proceeding, units: seconds. Default is 5
        SalvageStackItems_seconds = 150,                         // When salvaging stack items in your cargo every x seconds, units: seconds. Default is 180
        SalvageDelayBetweenActions_miliseconds=200,
        TravelerExitStationAmIInSpaceYet_seconds = 17,           // Traveler - Exit Station before you are in space delay, units: seconds. Default is 7
        TravelerNoStargatesFoundRetryDelay_seconds = 15,         // Traveler could not find any stargates, retry when this time has elapsed, units: seconds. Default is 15
        TravelerJumpedGateNextCommandDelay_seconds = 15,         // Traveler jumped a gate - delay before assuming we have loaded grid, units: seconds. Default is 15
        TravelerInWarpedNextCommandDelay_seconds = 15,           // Traveler is in warp - delay before processing another command, units: seconds. Default is 15
        WrecksDisappearAfter_minutes = 110,                      // used to determine how long a wreck will be in space: usually to delay salvaging until a later time, units: minutes. Default is 120 minutes (2 hours)
        AverageTimeToCompleteAMission_minutes = 30,              // average time for all missions, all races, all shiptypes (guestimated)... it is used to determine when to do things like salvage. units: minutes. Default is 30 
        AverageTimetoSalvageMultipleMissions_minutes = 30,       // average time it will take to salvage the multiple mission chain we plan on salvaging all in one go.
        CheckForWindows_seconds = 15                             // Check for and deal with modal windows every x seconds, units: seconds. Default is 15
     }
}