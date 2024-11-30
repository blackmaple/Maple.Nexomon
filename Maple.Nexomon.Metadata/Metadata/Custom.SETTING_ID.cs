namespace Maple.Nexomon.Metadata;

/// <summary>
/// ["Assembly-CSharp.dll".""."SETTING_ID"]
/// </summary>
public enum SETTING_ID : System.Byte
{


    locked = 0x00000001,

    seed = 0x00000002,

    copy_party_from_another_file = 0x00000003,

    copy_storage_from_another_file = 0x00000004,

    copy_items_from_another_file = 0x00000005,

    reset_player_nexomon_levels = 0x00000006,

    randomize_starters_any_tier_including_legendaries = 0x00000007,

    randomize_starters_any_tier = 0x00000008,

    randomize_starters_to_tier1_only = 0x00000009,

    randomize_wild_distributions = 0x0000000A,

    randomize_wild_encounters_completely = 0x0000000B,

    randomize_tamer_parties_completely = 0x0000000C,

    randomize_tamer_parties_keeping_original_tier = 0x0000000D,

    randomize_bosses = 0x0000000E,

    allow_capture_once_per_map_first_encounter = 0x0000000F,

    randomize_overworld_items = 0x00000010,

    disable_level_cap = 0x00000011,

    allow_high_tier_encounters = 0x00000012,

    difficulty_extra_weight = 0x00000013,

    permadeath = 0x00000014,

    item_limit_per_battle = 0x00000015,

    multiplier_income_wild = 0x00000016,

    multiplier_income_tamers = 0x00000017,

    multiplier_experience = 0x00000018,

    randomize_skilltrees_completely = 0x00000019,

    randomize_skilltrees_keeping_original_element = 0x0000001A,

    recorded_did_copy_any_data = 0x0000001B,

    recorded_count_monsters_copied_from_another_party = 0x0000001C,

    recorded_count_monsters_copied_from_another_storage = 0x0000001D,

    recorded_count_items_copied_from_another_inventory = 0x0000001E,

    disable_run_from_battles = 0x0000001F,

    mutate_tamer_teams_per_defeat = 0x00000020,

    randomize_tamer_parties_with_equal_or_greater_tiers = 0x00000021,

    disable_shops = 0x00000022,

    randomize_ore_boulders = 0x00000023,

    revert_evolution_stage_for_copied_nexomon = 0x00000024,

    permadeath_and_lock_file_on_game_over = 0x00000025,

    recorded_is_file_perma_locked = 0x00000026,

}
