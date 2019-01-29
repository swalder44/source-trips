﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Zapros
    {
        public string commandStringTest;
        public void ZaprPrLocal(int IDTS)
        {
            commandStringTest = "SELECT "
  + "`wd`.`id` AS `id`, "
  + "`wd`.`datetime` AS `datetime`, "
  + "CAST(`wd`.`datetime_local` AS date) AS `datepr`, "
  + "CAST(`wd`.`datetime_local` AS time) AS `timepr`, "
  + "`wd`.`datetime_local` AS `datetime_local`, "
  + "`wd`.`ms` AS `ms`, "
  + "`wd`.`wim` AS `wim`, "
  + "`wd`.`opposite_direction` AS `opposite_direction`, "
  + "`wd`.`wim_detector_id` AS `wim_detector_id`, "
  + "`wd`.`detection_id` AS `detection_id`, "
  + "`wd`.`detection_image_id` AS `detection_image_id`, "
  + "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
  + "`wd`.`time_distance_front_front` AS `time_distance_front_front`, "
  + "`wd`.`time_distance_back_front` AS `time_distance_back_front`, "
  + "`wd`.`vehicle_class` AS `vehicle_class`, "
  + "`wd`.`velocity` AS `velocity`, "
  + "`wd`.`length` AS `length`, "
  + "`wd`.`lp` AS `lp`, "
  + "`wd`.`lp_back` AS `lp_back`, "
  + "`wd`.`insert_timestamp` AS `insert_timestamp`, "
  + "`wd`.`total_weight` AS `total_weight`, "
  + "`wd`.`axles_count` AS `axles_count`, "
  + "`wd`.`axles_1_2_base` AS `axles_1_2_base`, "
  + "`wd`.`axles_2_3_base` AS `axles_2_3_base`, "
  + "`wd`.`axles_3_4_base` AS `axles_3_4_base`, "
  + "`wd`.`axles_4_5_base` AS `axles_4_5_base`, "
  + "`wd`.`axles_5_6_base` AS `axles_5_6_base`, "
  + "`wd`.`axles_6_7_base` AS `axles_6_7_base`, "
  + "`wd`.`axles_7_8_base` AS `axles_7_8_base`, "
  + "`wd`.`axles_8_9_base` AS `axles_8_9_base`, "
  + "`wd`.`axle_1_leftside_load` AS `axle_1_leftside_load`, "
  + "`wd`.`axle_1_rightside_load` AS `axle_1_rightside_load`, "
  + "`wd`.`axle_2_leftside_load` AS `axle_2_leftside_load`, "
  + "`wd`.`axle_2_rightside_load` AS `axle_2_rightside_load`, "
  + "`wd`.`axle_3_leftside_load` AS `axle_3_leftside_load`, "
  + "`wd`.`axle_3_rightside_load` AS `axle_3_rightside_load`, "
  + "`wd`.`axle_4_leftside_load` AS `axle_4_leftside_load`, "
  + "`wd`.`axle_4_rightside_load` AS `axle_4_rightside_load`, "
  + "`wd`.`axle_5_leftside_load` AS `axle_5_leftside_load`, "
  + "`wd`.`axle_5_rightside_load` AS `axle_5_rightside_load`, "
  + "`wd`.`axle_6_leftside_load` AS `axle_6_leftside_load`, "
  + "`wd`.`axle_6_rightside_load` AS `axle_6_rightside_load`, "
  + "`wd`.`axle_7_leftside_load` AS `axle_7_leftside_load`, "
  + "`wd`.`axle_7_rightside_load` AS `axle_7_rightside_load`, "
  + "`wd`.`axle_8_leftside_load` AS `axle_8_leftside_load`, "
  + "`wd`.`axle_8_rightside_load` AS `axle_8_rightside_load`, "
  + "`wd`.`axle_9_leftside_load` AS `axle_9_leftside_load`, "
  + "`wd`.`axle_9_rightside_load` AS `axle_9_rightside_load`, "
  + "`wd`.`overweighting` AS `overweighting`, "
  + "`wd`.`dual_tire` AS `dual_tire`, "
  + "`wd`.`validity` AS `validity`, "
  + "`wd`.`validity_flags` AS `validity_flags`, "
  + "`wd`.`error_flags` AS `error_flags`, "
  + "`wd`.`temp_internal` AS `temp_internal`, "
  + "`wd`.`temp_asphalt` AS `temp_asphalt`, "
  + "`wd`.`acceleration` AS `acceleration`, "
  + "`wd`.`overweight_desc` AS `overweight_desc`, "
  + "`wd`.`car_layout` AS `car_layout`, "
  + "`wd`.`s_height` AS `s_height`, "
  + "`wd`.`s_width` AS `s_width`, "
  + "`wd`.`s_length` AS `s_length`, "
  + "`wd`.`trailer_presence` AS `trailer_presence`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN LEFT(`wd`.`lp`, 1) ELSE 'А' END) AS `n1`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 2, 1) ELSE '0' END) AS `n2`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 3, 1) ELSE '0' END) AS `n3`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 4, 1) ELSE '0' END) AS `n4`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 5, 1) ELSE 'А' END) AS `n5`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 6, 1) ELSE 'А' END) AS `n6`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 7, 1) ELSE '0' END) AS `n7`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 8, 1) ELSE '0' END) AS `n8`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 9, 1) ELSE '0' END) AS `n9`, "
  + "IFNULL((`wd`.`axle_1_leftside_load` + `wd`.`axle_1_rightside_load`), 0) AS `o1m`, "
  + "IFNULL((`wd`.`axles_1_2_base` / 100), 0) AS `base1_2`, "
  + "IFNULL(LEFT(`wd`.`dual_tire`, 1), 0) AS `dbl1`, "
  + "IFNULL((`wd`.`axle_2_leftside_load` + `wd`.`axle_2_rightside_load`), 0) AS `o2m`, "
  + "IFNULL((`wd`.`axles_2_3_base` / 100), 0) AS `base2_3`, "
  + "IFNULL(SUBSTR(`wd`.`dual_tire`, 2, 1), 0) AS `dbl2`, "
  + "IFNULL((`wd`.`axle_3_leftside_load` + `wd`.`axle_3_rightside_load`), 0) AS `o3m`, "
  + "IFNULL((`wd`.`axle_4_leftside_load` + `wd`.`axle_4_rightside_load`), 0) AS `o4m`, "
  + "IFNULL((`wd`.`axle_5_leftside_load` + `wd`.`axle_5_rightside_load`), 0) AS `o5m`, "
  + "IFNULL((`wd`.`axle_6_leftside_load` + `wd`.`axle_6_rightside_load`), 0) AS `o6m`, "
  + "IFNULL((`wd`.`axle_7_leftside_load` + `wd`.`axle_7_rightside_load`), 0) AS `o7m`, "
  + "IFNULL((`wd`.`axle_8_leftside_load` + `wd`.`axle_8_rightside_load`), 0) AS `o8m`, "
  + "IFNULL((`wd`.`axle_9_leftside_load` + `wd`.`axle_9_rightside_load`), 0) AS `o9m`, "
  + "IFNULL((`wd`.`axles_3_4_base` / 100), 0) AS `base3_4`, "
  + "IFNULL((`wd`.`axles_4_5_base` / 100), 0) AS `base4_5`, "
  + "IFNULL((`wd`.`axles_5_6_base` / 100), 0) AS `base5_6`, "
  + "IFNULL((`wd`.`axles_6_7_base` / 100), 0) AS `base6_7`, "
  + "IFNULL((`wd`.`axles_7_8_base` / 100), 0) AS `base7_8`, "
  + "IFNULL((`wd`.`axles_8_9_base` / 100), 0) AS `base8_9`, "
  + "SUBSTR(`wd`.`dual_tire`, 3, 1) AS `dbl3`, "
  + "SUBSTR(`wd`.`dual_tire`, 4, 1) AS `dbl4`, "
  + "SUBSTR(`wd`.`dual_tire`, 5, 1) AS `dbl5`, "
  + "SUBSTR(`wd`.`dual_tire`, 6, 1) AS `dbl6`, "
  + "SUBSTR(`wd`.`dual_tire`, 7, 1) AS `dbl7`, "
  + "SUBSTR(`wd`.`dual_tire`, 8, 1) AS `dbl8`, "
  + "SUBSTR(`wd`.`dual_tire`, 9, 1) AS `dbl9`, "
  + "IFNULL((`wd`.`length` / 10), 0) AS `base1_n`, "
  + "`dd`.`lp_image` AS `lp_image`, "
  + "`ddi`.`image` AS `ObzLob`, "
  + "`si`.`image` AS `Obz`, "
  + "`dd`.`image_id` AS `image_id`, "
  + "`dd`.`lp` AS `expr1`, "
  + "`dd`.`detector` AS `detector`, "
  + "`dd`.`vehicle_class` AS `dd_vehicle_class`, "
  + "`dd`.`insert_timestamp` AS `dd_insert_timestamp`, "
  + "`dd`.`ilpc` AS `ilpc`, "
  + "`dd`.`ms` AS `dd_ms`, "
  + "`dd`.`datetime` AS `dd_datetime`, "
  + "`ddi`.`state` AS `state`, "
  + "`ddi`.`state_changed` AS `state_changed`, "
  + "`ddi`.`detection_image_id` AS `ddi_detection_image_id`, "
  + "`ddi`.`parent_image_id` AS `parent_image_id`, "
  + "`ddi`.`insert_timestamp` AS `ddi_insert_timestamp`, "
  + "`si`.`image_id` AS `si_image_id`, "
  + "`si`.`insert_timestamp` AS `si_insert_timestamp`, "
  + "`si`.`image_type` AS `image_type`, "
  + "`si`.`sensor` AS `sensor`, "
  + "`si`.`create_time_ms` AS `create_time_ms`, "
  + "`si`.`create_time` AS `create_time` "
+ "FROM ((((`camloc`.`wims_detections` `wd` "
  + "JOIN `camloc`.`detectors_detections` `dd` "
   + " ON ((`wd`.`detection_image_id` = `dd`.`image_id`))) "
  + "JOIN `camloc`.`detectors_detections_images` `ddi` "
   + " ON ((`wd`.`detection_image_id` = `ddi`.`detection_image_id`))) "
  + "JOIN `camloc`.`sensors_detections_images` `sdi` "
   + " ON ((`wd`.`detection_id` = `sdi`.`detection_id`))) "
 + " JOIN `camloc`.`sensors_images` `si` "
   + " ON ((`sdi`.`image_id` = `si`.`image_id`))) "
+ "WHERE (`wd`.`id` = " + IDTS + ") "
+ "ORDER BY `wd`.`datetime` DESC;"; 
        }

        public void ZaprPrLocalNAR(int IDTS)
        {
            commandStringTest = "SELECT "
  + "`wd`.`id` AS `id`, "
  + "`wd`.`datetime` AS `datetime`, "
  + "CAST(`wd`.`datetime_local` AS date) AS `datepr`, "
  + "CAST(`wd`.`datetime_local` AS time) AS `timepr`, "
  + "`wd`.`datetime_local` AS `datetime_local`, "
  + "`wd`.`ms` AS `ms`, "
  + "`wd`.`wim` AS `wim`, "
  + "`wd`.`opposite_direction` AS `opposite_direction`, "
  + "`wd`.`wim_detector_id` AS `wim_detector_id`, "
  + "`wd`.`detection_id` AS `detection_id`, "
  + "`wd`.`detection_image_id` AS `detection_image_id`, "
  + "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
  + "`wd`.`time_distance_front_front` AS `time_distance_front_front`, "
  + "`wd`.`time_distance_back_front` AS `time_distance_back_front`, "
  + "`wd`.`vehicle_class` AS `vehicle_class`, "
  + "`wd`.`velocity` AS `velocity`, "
  + "`wd`.`length` AS `length`, "
  + "`wd`.`lp` AS `lp`, "
  + "`wd`.`lp_back` AS `lp_back`, "
  + "`wd`.`insert_timestamp` AS `insert_timestamp`, "
  + "`wd`.`total_weight` AS `total_weight`, "
  + "`wd`.`axles_count` AS `axles_count`, "
  + "`wd`.`axles_1_2_base` AS `axles_1_2_base`, "
  + "`wd`.`axles_2_3_base` AS `axles_2_3_base`, "
  + "`wd`.`axles_3_4_base` AS `axles_3_4_base`, "
  + "`wd`.`axles_4_5_base` AS `axles_4_5_base`, "
  + "`wd`.`axles_5_6_base` AS `axles_5_6_base`, "
  + "`wd`.`axles_6_7_base` AS `axles_6_7_base`, "
  + "`wd`.`axles_7_8_base` AS `axles_7_8_base`, "
  + "`wd`.`axles_8_9_base` AS `axles_8_9_base`, "
  + "`wd`.`axle_1_leftside_load` AS `axle_1_leftside_load`, "
  + "`wd`.`axle_1_rightside_load` AS `axle_1_rightside_load`, "
  + "`wd`.`axle_2_leftside_load` AS `axle_2_leftside_load`, "
  + "`wd`.`axle_2_rightside_load` AS `axle_2_rightside_load`, "
  + "`wd`.`axle_3_leftside_load` AS `axle_3_leftside_load`, "
  + "`wd`.`axle_3_rightside_load` AS `axle_3_rightside_load`, "
  + "`wd`.`axle_4_leftside_load` AS `axle_4_leftside_load`, "
  + "`wd`.`axle_4_rightside_load` AS `axle_4_rightside_load`, "
  + "`wd`.`axle_5_leftside_load` AS `axle_5_leftside_load`, "
  + "`wd`.`axle_5_rightside_load` AS `axle_5_rightside_load`, "
  + "`wd`.`axle_6_leftside_load` AS `axle_6_leftside_load`, "
  + "`wd`.`axle_6_rightside_load` AS `axle_6_rightside_load`, "
  + "`wd`.`axle_7_leftside_load` AS `axle_7_leftside_load`, "
  + "`wd`.`axle_7_rightside_load` AS `axle_7_rightside_load`, "
  + "`wd`.`axle_8_leftside_load` AS `axle_8_leftside_load`, "
  + "`wd`.`axle_8_rightside_load` AS `axle_8_rightside_load`, "
  + "`wd`.`axle_9_leftside_load` AS `axle_9_leftside_load`, "
  + "`wd`.`axle_9_rightside_load` AS `axle_9_rightside_load`, "
  + "`wd`.`overweighting` AS `overweighting`, "
  + "`wd`.`dual_tire` AS `dual_tire`, "
  + "`wd`.`validity` AS `validity`, "
  + "`wd`.`validity_flags` AS `validity_flags`, "
  + "`wd`.`error_flags` AS `error_flags`, "
  + "`wd`.`temp_internal` AS `temp_internal`, "
  + "`wd`.`temp_asphalt` AS `temp_asphalt`, "
  + "`wd`.`acceleration` AS `acceleration`, "
  + "`wd`.`overweight_desc` AS `overweight_desc`, "
  + "`wd`.`car_layout` AS `car_layout`, "
  + "`wd`.`s_height` AS `s_height`, "
  + "`wd`.`s_width` AS `s_width`, "
  + "`wd`.`s_length` AS `s_length`, "
  + "`wd`.`trailer_presence` AS `trailer_presence`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN LEFT(`wd`.`lp`, 1) ELSE 'А' END) AS `n1`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 2, 1) ELSE '0' END) AS `n2`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 3, 1) ELSE '0' END) AS `n3`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 4, 1) ELSE '0' END) AS `n4`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 5, 1) ELSE 'А' END) AS `n5`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 6, 1) ELSE 'А' END) AS `n6`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 7, 1) ELSE '0' END) AS `n7`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 8, 1) ELSE '0' END) AS `n8`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 9, 1) ELSE '0' END) AS `n9`, "
  + "IFNULL((`wd`.`axle_1_leftside_load` + `wd`.`axle_1_rightside_load`), 0) AS `o1m`, "
  + "IFNULL((`wd`.`axles_1_2_base` / 100), 0) AS `base1_2`, "
  + "IFNULL(LEFT(`wd`.`dual_tire`, 1), 0) AS `dbl1`, "
  + "IFNULL((`wd`.`axle_2_leftside_load` + `wd`.`axle_2_rightside_load`), 0) AS `o2m`, "
  + "IFNULL((`wd`.`axles_2_3_base` / 100), 0) AS `base2_3`, "
  + "IFNULL(SUBSTR(`wd`.`dual_tire`, 2, 1), 0) AS `dbl2`, "
  + "IFNULL((`wd`.`axle_3_leftside_load` + `wd`.`axle_3_rightside_load`), 0) AS `o3m`, "
  + "IFNULL((`wd`.`axle_4_leftside_load` + `wd`.`axle_4_rightside_load`), 0) AS `o4m`, "
  + "IFNULL((`wd`.`axle_5_leftside_load` + `wd`.`axle_5_rightside_load`), 0) AS `o5m`, "
  + "IFNULL((`wd`.`axle_6_leftside_load` + `wd`.`axle_6_rightside_load`), 0) AS `o6m`, "
  + "IFNULL((`wd`.`axle_7_leftside_load` + `wd`.`axle_7_rightside_load`), 0) AS `o7m`, "
  + "IFNULL((`wd`.`axle_8_leftside_load` + `wd`.`axle_8_rightside_load`), 0) AS `o8m`, "
  + "IFNULL((`wd`.`axle_9_leftside_load` + `wd`.`axle_9_rightside_load`), 0) AS `o9m`, "
  + "IFNULL((`wd`.`axles_3_4_base` / 100), 0) AS `base3_4`, "
  + "IFNULL((`wd`.`axles_4_5_base` / 100), 0) AS `base4_5`, "
  + "IFNULL((`wd`.`axles_5_6_base` / 100), 0) AS `base5_6`, "
  + "IFNULL((`wd`.`axles_6_7_base` / 100), 0) AS `base6_7`, "
  + "IFNULL((`wd`.`axles_7_8_base` / 100), 0) AS `base7_8`, "
  + "IFNULL((`wd`.`axles_8_9_base` / 100), 0) AS `base8_9`, "
  + "SUBSTR(`wd`.`dual_tire`, 3, 1) AS `dbl3`, "
  + "SUBSTR(`wd`.`dual_tire`, 4, 1) AS `dbl4`, "
  + "SUBSTR(`wd`.`dual_tire`, 5, 1) AS `dbl5`, "
  + "SUBSTR(`wd`.`dual_tire`, 6, 1) AS `dbl6`, "
  + "SUBSTR(`wd`.`dual_tire`, 7, 1) AS `dbl7`, "
  + "SUBSTR(`wd`.`dual_tire`, 8, 1) AS `dbl8`, "
  + "SUBSTR(`wd`.`dual_tire`, 9, 1) AS `dbl9`, "
  + "IFNULL((`wd`.`length` / 10), 0) AS `base1_n`, "
  + "`dd`.`lp_image` AS `lp_image`, "
  + "`ddi`.`image` AS `ObzLob`, "
  + "`si`.`image` AS `Obz`, "
  + "`dd`.`image_id` AS `image_id`, "
  + "`dd`.`lp` AS `expr1`, "
  + "`dd`.`detector` AS `detector`, "
  + "`dd`.`vehicle_class` AS `dd_vehicle_class`, "
  + "`dd`.`insert_timestamp` AS `dd_insert_timestamp`, "
  + "`dd`.`ilpc` AS `ilpc`, "
  + "`dd`.`ms` AS `dd_ms`, "
  + "`dd`.`datetime` AS `dd_datetime`, "
  + "`ddi`.`state` AS `state`, "
  + "`ddi`.`state_changed` AS `state_changed`, "
  + "`ddi`.`detection_image_id` AS `ddi_detection_image_id`, "
  + "`ddi`.`parent_image_id` AS `parent_image_id`, "
  + "`ddi`.`insert_timestamp` AS `ddi_insert_timestamp`, "
  + "`si`.`image_id` AS `si_image_id`, "
  + "`si`.`insert_timestamp` AS `si_insert_timestamp`, "
  + "`si`.`image_type` AS `image_type`, "
  + "`si`.`sensor` AS `sensor`, "
  + "`si`.`create_time_ms` AS `create_time_ms`, "
  + "`si`.`create_time` AS `create_time` "
+ "FROM ((((`test`.`wims_det_r` `wd` "
  + "JOIN `camloc`.`detectors_detections` `dd` "
   + " ON ((`wd`.`detection_image_id` = `dd`.`image_id`))) "
  + "JOIN `camloc`.`detectors_detections_images` `ddi` "
   + " ON ((`wd`.`detection_image_id` = `ddi`.`detection_image_id`))) "
  + "JOIN `camloc`.`sensors_detections_images` `sdi` "
   + " ON ((`wd`.`detection_id` = `sdi`.`detection_id`))) "
 + " JOIN `camloc`.`sensors_images` `si` "
   + " ON ((`sdi`.`image_id` = `si`.`image_id`))) "
+ "WHERE (`wd`.`id` = " + IDTS + ") "
+ "ORDER BY `wd`.`datetime` DESC;";
        }

        public void ZaprPrCam()///int IDTS)
        {
            commandStringTest = "SELECT "
  + "`wd`.`id` AS `id`, "
  + "`wd`.`datetime` AS `datetime`, "
  + "CAST(`wd`.`datetime_local` AS date) AS `datepr`, "
  + "CAST(`wd`.`datetime_local` AS time) AS `timepr`, "
  + "`wd`.`datetime_local` AS `datetime_local`, "
  + "`wd`.`ms` AS `ms`, "
  + "`wd`.`wim` AS `wim`, "
  + "`wd`.`opposite_direction` AS `opposite_direction`, "
  + "`wd`.`wim_detector_id` AS `wim_detector_id`, "
  + "`wd`.`detection_id` AS `detection_id`, "
  + "`wd`.`detection_image_id` AS `detection_image_id`, "
  + "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
  + "`wd`.`time_distance_front_front` AS `time_distance_front_front`, "
  + "`wd`.`time_distance_back_front` AS `time_distance_back_front`, "
  + "`wd`.`vehicle_class` AS `vehicle_class`, "
  + "`wd`.`velocity` AS `velocity`, "
  + "`wd`.`length` AS `length`, "
  + "`wd`.`lp` AS `lp`, "
  + "`wd`.`lp_back` AS `lp_back`, "
  + "`wd`.`insert_timestamp` AS `insert_timestamp`, "
  + "`wd`.`total_weight` AS `total_weight`, "
  + "`wd`.`axles_count` AS `axles_count`, "
  + "`wd`.`axles_1_2_base` AS `axles_1_2_base`, "
  + "`wd`.`axles_2_3_base` AS `axles_2_3_base`, "
  + "`wd`.`axles_3_4_base` AS `axles_3_4_base`, "
  + "`wd`.`axles_4_5_base` AS `axles_4_5_base`, "
  + "`wd`.`axles_5_6_base` AS `axles_5_6_base`, "
  + "`wd`.`axles_6_7_base` AS `axles_6_7_base`, "
  + "`wd`.`axles_7_8_base` AS `axles_7_8_base`, "
  + "`wd`.`axles_8_9_base` AS `axles_8_9_base`, "
  + "`wd`.`axle_1_leftside_load` AS `axle_1_leftside_load`, "
  + "`wd`.`axle_1_rightside_load` AS `axle_1_rightside_load`, "
  + "`wd`.`axle_2_leftside_load` AS `axle_2_leftside_load`, "
  + "`wd`.`axle_2_rightside_load` AS `axle_2_rightside_load`, "
  + "`wd`.`axle_3_leftside_load` AS `axle_3_leftside_load`, "
  + "`wd`.`axle_3_rightside_load` AS `axle_3_rightside_load`, "
  + "`wd`.`axle_4_leftside_load` AS `axle_4_leftside_load`, "
  + "`wd`.`axle_4_rightside_load` AS `axle_4_rightside_load`, "
  + "`wd`.`axle_5_leftside_load` AS `axle_5_leftside_load`, "
  + "`wd`.`axle_5_rightside_load` AS `axle_5_rightside_load`, "
  + "`wd`.`axle_6_leftside_load` AS `axle_6_leftside_load`, "
  + "`wd`.`axle_6_rightside_load` AS `axle_6_rightside_load`, "
  + "`wd`.`axle_7_leftside_load` AS `axle_7_leftside_load`, "
  + "`wd`.`axle_7_rightside_load` AS `axle_7_rightside_load`, "
  + "`wd`.`axle_8_leftside_load` AS `axle_8_leftside_load`, "
  + "`wd`.`axle_8_rightside_load` AS `axle_8_rightside_load`, "
  + "`wd`.`axle_9_leftside_load` AS `axle_9_leftside_load`, "
  + "`wd`.`axle_9_rightside_load` AS `axle_9_rightside_load`, "
  + "`wd`.`overweighting` AS `overweighting`, "
  + "`wd`.`dual_tire` AS `dual_tire`, "
  + "`wd`.`validity` AS `validity`, "
  + "`wd`.`validity_flags` AS `validity_flags`, "
  + "`wd`.`error_flags` AS `error_flags`, "
  + "`wd`.`temp_internal` AS `temp_internal`, "
  + "`wd`.`temp_asphalt` AS `temp_asphalt`, "
  + "`wd`.`acceleration` AS `acceleration`, "
  + "`wd`.`overweight_desc` AS `overweight_desc`, "
  + "`wd`.`car_layout` AS `car_layout`, "
  + "`wd`.`s_height` AS `s_height`, "
  + "`wd`.`s_width` AS `s_width`, "
  + "`wd`.`s_length` AS `s_length`, "
  + "`wd`.`trailer_presence` AS `trailer_presence`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN LEFT(`wd`.`lp`, 1) ELSE 'А' END) AS `n1`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 2, 1) ELSE '0' END) AS `n2`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 3, 1) ELSE '0' END) AS `n3`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 4, 1) ELSE '0' END) AS `n4`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 5, 1) ELSE 'А' END) AS `n5`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 6, 1) ELSE 'А' END) AS `n6`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 7, 1) ELSE '0' END) AS `n7`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 8, 1) ELSE '0' END) AS `n8`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 9, 1) ELSE '0' END) AS `n9`, "
  + "IFNULL((`wd`.`axle_1_leftside_load` + `wd`.`axle_1_rightside_load`), 0) AS `o1m`, "
  + "IFNULL((`wd`.`axles_1_2_base` / 100), 0) AS `base1_2`, "
  + "IFNULL(LEFT(`wd`.`dual_tire`, 1), 0) AS `dbl1`, "
  + "IFNULL((`wd`.`axle_2_leftside_load` + `wd`.`axle_2_rightside_load`), 0) AS `o2m`, "
  + "IFNULL((`wd`.`axles_2_3_base` / 100), 0) AS `base2_3`, "
  + "IFNULL(SUBSTR(`wd`.`dual_tire`, 2, 1), 0) AS `dbl2`, "
  + "IFNULL((`wd`.`axle_3_leftside_load` + `wd`.`axle_3_rightside_load`), 0) AS `o3m`, "
  + "IFNULL((`wd`.`axle_4_leftside_load` + `wd`.`axle_4_rightside_load`), 0) AS `o4m`, "
  + "IFNULL((`wd`.`axle_5_leftside_load` + `wd`.`axle_5_rightside_load`), 0) AS `o5m`, "
  + "IFNULL((`wd`.`axle_6_leftside_load` + `wd`.`axle_6_rightside_load`), 0) AS `o6m`, "
  + "IFNULL((`wd`.`axle_7_leftside_load` + `wd`.`axle_7_rightside_load`), 0) AS `o7m`, "
  + "IFNULL((`wd`.`axle_8_leftside_load` + `wd`.`axle_8_rightside_load`), 0) AS `o8m`, "
  + "IFNULL((`wd`.`axle_9_leftside_load` + `wd`.`axle_9_rightside_load`), 0) AS `o9m`, "
  + "IFNULL((`wd`.`axles_3_4_base` / 100), 0) AS `base3_4`, "
  + "IFNULL((`wd`.`axles_4_5_base` / 100), 0) AS `base4_5`, "
  + "IFNULL((`wd`.`axles_5_6_base` / 100), 0) AS `base5_6`, "
  + "IFNULL((`wd`.`axles_6_7_base` / 100), 0) AS `base6_7`, "
  + "IFNULL((`wd`.`axles_7_8_base` / 100), 0) AS `base7_8`, "
  + "IFNULL((`wd`.`axles_8_9_base` / 100), 0) AS `base8_9`, "
  + "SUBSTR(`wd`.`dual_tire`, 3, 1) AS `dbl3`, "
  + "SUBSTR(`wd`.`dual_tire`, 4, 1) AS `dbl4`, "
  + "SUBSTR(`wd`.`dual_tire`, 5, 1) AS `dbl5`, "
  + "SUBSTR(`wd`.`dual_tire`, 6, 1) AS `dbl6`, "
  + "SUBSTR(`wd`.`dual_tire`, 7, 1) AS `dbl7`, "
  + "SUBSTR(`wd`.`dual_tire`, 8, 1) AS `dbl8`, "
  + "SUBSTR(`wd`.`dual_tire`, 9, 1) AS `dbl9`, "
  + "IFNULL((`wd`.`length` / 10), 0) AS `base1_n`, "
  + "`dd`.`lp_image` AS `lp_image`, "
  + "`ddi`.`image` AS `ObzLob`, "
  + "`si`.`image` AS `Obz`, "
  + "`dd`.`image_id` AS `image_id`, "
  + "`dd`.`lp` AS `expr1`, "
  + "`dd`.`detector` AS `detector`, "
  + "`dd`.`vehicle_class` AS `dd_vehicle_class`, "
  + "`dd`.`insert_timestamp` AS `dd_insert_timestamp`, "
  + "`dd`.`ilpc` AS `ilpc`, "
  + "`dd`.`ms` AS `dd_ms`, "
  + "`dd`.`datetime` AS `dd_datetime`, "
  + "`ddi`.`state` AS `state`, "
  + "`ddi`.`state_changed` AS `state_changed`, "
  + "`ddi`.`detection_image_id` AS `ddi_detection_image_id`, "
  + "`ddi`.`parent_image_id` AS `parent_image_id`, "
  + "`ddi`.`insert_timestamp` AS `ddi_insert_timestamp`, "
  + "`si`.`image_id` AS `si_image_id`, "
  + "`si`.`insert_timestamp` AS `si_insert_timestamp`, "
  + "`si`.`image_type` AS `image_type`, "
  + "`si`.`sensor` AS `sensor`, "
  + "`si`.`create_time_ms` AS `create_time_ms`, "
  + "`si`.`create_time` AS `create_time` "
+ "FROM ((((`wims_detections` `wd` "
  + "JOIN `detectors_detections` `dd` "
   + " ON ((`wd`.`detection_image_id` = `dd`.`image_id`))) "
  + "JOIN `detectors_detections_images` `ddi` "
   + " ON ((`wd`.`detection_image_id` = `ddi`.`detection_image_id`))) "
  + "JOIN `sensors_detections_images` `sdi` "
   + " ON ((`wd`.`detection_id` = `sdi`.`detection_id`))) "
 + " JOIN `sensors_images` `si` "
   + " ON ((`sdi`.`image_id` = `si`.`image_id`))) "
+ "WHERE wd.datetime_local >= DATE_SUB(now(), INTERVAL  +10 SECOND);";
        }
        public void ZaprPrCamTab(int COs, string D1, string D2, int Cl, string WM)///int IDTS)
        {
            commandStringTest = "SELECT "
  + "`wd`.`id` AS `ID`, "
  + "`wd`.`datetime` AS `datetime`, "
  + "CAST(`wd`.`datetime_local` AS date) AS `Дата проезда`,"
  + " CAST(`wd`.`datetime_local` AS time) AS `Время проезда`, "
  + "`wd`.`datetime_local` AS `datetime_local`, "
  + "`wd`.`wim` AS `№ комплекса`, "
  + "`wd`.`wim_detector_id` AS `wim_detector_id`, "
  + "`wd`.`detection_id` AS `detection_id`, "
  + "`wd`.`detection_image_id` AS `detection_image_id`, "
  + "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
  + "`wd`.`vehicle_class` AS `Класс`, "
  + "`wd`.`velocity` AS `velocity`, "
  + "`wd`.`length` AS `Длина ТС`, "
  + "`wd`.`lp` AS `ГРЗ`, "
  + "`wd`.`lp_back` AS `lp_back`, "
  + "`wd`.`total_weight` AS `Общий вес`, "
  + "`wd`.`axles_count` AS `Кол-во осей`, "
  + "`wd`.`axles_1_2_base` AS `axles_1_2_base`, "
  + "`wd`.`axles_2_3_base` AS `axles_2_3_base`, "
  + "`wd`.`axles_3_4_base` AS `axles_3_4_base`, "
  + "`wd`.`axles_4_5_base` AS `axles_4_5_base`, "
  + "`wd`.`axles_5_6_base` AS `axles_5_6_base`, "
  + "`wd`.`axles_6_7_base` AS `axles_6_7_base`, "
  + "`wd`.`axles_7_8_base` AS `axles_7_8_base`, "
  + "`wd`.`axles_8_9_base` AS `axles_8_9_base`,"
  + "`wd`.`dual_tire` AS `dual_tire`, "
  + "`wd`.`validity` AS `validity`, "
  + "`wd`.`validity_flags` AS `validity_flags`, "
  + "`wd`.`error_flags` AS `error_flags`, "
  + "`wd`.`car_layout` AS `car_layout`, "
  + "`wd`.`s_height` AS `s_height`, "
  + "`wd`.`s_width` AS `s_width`, "
  + "`wd`.`s_length` AS `s_length`, "
  + "`wd`.`trailer_presence` AS `trailer_presence`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN LEFT(`wd`.`lp`, 1) ELSE 'А' END) AS `n1`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 2, 1) ELSE '0' END) AS `n2`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 3, 1) ELSE '0' END) AS `n3`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 4, 1) ELSE '0' END) AS `n4`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 5, 1) ELSE 'А' END) AS `n5`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 6, 1) ELSE 'А' END) AS `n6`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 7, 1) ELSE '0' END) AS `n7`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 8, 1) ELSE '0' END) AS `n8`, "
  + "(CASE WHEN (LENGTH(`wd`.`lp`) > 3) THEN SUBSTR(`wd`.`lp`, 9, 1) ELSE '0' END) AS `n9`, "
  + "IFNULL((`wd`.`axle_1_leftside_load` + `wd`.`axle_1_rightside_load`), 0) AS `o1m`, "
  + "IFNULL((`wd`.`axles_1_2_base` / 100), 0) AS `base1_2`, "
  + "IFNULL(LEFT(`wd`.`dual_tire`, 1), 0) AS `dbl1`, "
  + "IFNULL((`wd`.`axle_2_leftside_load` + `wd`.`axle_2_rightside_load`), 0) AS `o2m`, "
  + "IFNULL((`wd`.`axles_2_3_base` / 100), 0) AS `base2_3`, "
  + "IFNULL(SUBSTR(`wd`.`dual_tire`, 2, 1), 0) AS `dbl2`, "
  + "IFNULL((`wd`.`axle_3_leftside_load` + `wd`.`axle_3_rightside_load`), 0) AS `o3m`, "
  + "IFNULL((`wd`.`axle_4_leftside_load` + `wd`.`axle_4_rightside_load`), 0) AS `o4m`, "
  + "IFNULL((`wd`.`axle_5_leftside_load` + `wd`.`axle_5_rightside_load`), 0) AS `o5m`, "
  + "IFNULL((`wd`.`axle_6_leftside_load` + `wd`.`axle_6_rightside_load`), 0) AS `o6m`, "
  + "IFNULL((`wd`.`axle_7_leftside_load` + `wd`.`axle_7_rightside_load`), 0) AS `o7m`, "
  + "IFNULL((`wd`.`axle_8_leftside_load` + `wd`.`axle_8_rightside_load`), 0) AS `o8m`, "
  + "IFNULL((`wd`.`axle_9_leftside_load` + `wd`.`axle_9_rightside_load`), 0) AS `o9m`, "
  + "IFNULL((`wd`.`axles_3_4_base` / 100), 0) AS `base3_4`, "
  + "IFNULL((`wd`.`axles_4_5_base` / 100), 0) AS `base4_5`, "
  + "IFNULL((`wd`.`axles_5_6_base` / 100), 0) AS `base5_6`, "
  + "IFNULL((`wd`.`axles_6_7_base` / 100), 0) AS `base6_7`, "
  + "IFNULL((`wd`.`axles_7_8_base` / 100), 0) AS `base7_8`, "
  + "IFNULL((`wd`.`axles_8_9_base` / 100), 0) AS `base8_9`, "
  + "SUBSTR(`wd`.`dual_tire`, 3, 1) AS `dbl3`, "
  + "SUBSTR(`wd`.`dual_tire`, 4, 1) AS `dbl4`, "
  + "SUBSTR(`wd`.`dual_tire`, 5, 1) AS `dbl5`, "
  + "SUBSTR(`wd`.`dual_tire`, 6, 1) AS `dbl6`, "
  + "SUBSTR(`wd`.`dual_tire`, 7, 1) AS `dbl7`, "
  + "SUBSTR(`wd`.`dual_tire`, 8, 1) AS `dbl8`, "
  + "SUBSTR(`wd`.`dual_tire`, 9, 1) AS `dbl9`, "
  + "IFNULL((`wd`.`length` / 10), 0) AS `base1_n` "
  + "FROM `wims_detections` `wd` "
  ;

            if ((COs > 0) || (D1 != null && D2 != null) || (Cl > 0) || ((WM != "") && (WM != null)))
            {
                commandStringTest = commandStringTest + " WHERE ";
                if (COs > 0)
                {
                    if ((D1 != null && D2 != null) || (Cl > 0) || ((WM != "") && (WM != null)))
                    {
                        commandStringTest = commandStringTest + " wd.axles_count = " + COs + " AND ";
                    }
                }
                else { commandStringTest = commandStringTest + " wd.axles_count = " + COs + " "; }
                if (D1 != null && D2 != null)
                {
                    if ((Cl > 0) || ((WM != "") && (WM != null)))
                    {
                        commandStringTest = commandStringTest + " `wd`.`datetime_local` BETWEEN ('" + D1 + "') AND ('" + D2 + "') AND ";
                    }
                    else { commandStringTest = commandStringTest + " `wd`.`datetime_local` BETWEEN ('" + D1 + "') AND ('" + D2 + "') "; }
                }
                if (Cl > 0)
                {
                    if (WM != "" && WM != null)
                    {
                        commandStringTest = commandStringTest + " wd.vehicle_class = " + Cl + " AND ";
                    }
                    else { commandStringTest = commandStringTest + " wd.vehicle_class = " + Cl + " "; }
                }
                if (WM != "" && WM != null)
                { commandStringTest = commandStringTest + " wd.wim = '" + WM + "' "; }
                commandStringTest = commandStringTest + " ORDER BY `wd`.`datetime` DESC;" ;
            }
        }

        public void ZaprPrCamTabLoc(int COs, string D1, string D2, int Cl, string WM)///int IDTS)
        {
            //if (IDTS == 0)
            //{
                commandStringTest = "SELECT * "
                                    + "FROM test.allandnapr ";
            //}
    //        else
    //        {

    //            commandStringTest = "SELECT"
    //+ " allandnapr.* "
    //+ "FROM test.allandnapr ";
                   
    //        }
    

            if ((COs > 0) || (D1 != null && D2 != null) || (Cl > 0) || ((WM != "") && (WM != null)))
            {
                commandStringTest = commandStringTest + " WHERE ";
                if (COs > 0)
                {
                    if ((D1 != null && D2 != null) || (Cl > 0) || ((WM != "") && (WM != null)))
                    {
                        commandStringTest = commandStringTest + " test.allandnapr.AxleCount = " + COs + " AND ";
                    }
                }
                else { commandStringTest = commandStringTest + " test.allandnapr.AxleCount = " + COs + " "; }
                if (D1 != null && D2 != null)
                {
                    if ((Cl > 0) || ((WM != "") && (WM != null)))
                    {
                        commandStringTest = commandStringTest + " test.allandnapr.`Created` BETWEEN ('" + D1 + "') AND ('" + D2 + "') AND ";
                    }
                    else { commandStringTest = commandStringTest + " test.allandnapr.`Created` BETWEEN ('" + D1 + "') AND ('" + D2 + "') "; }
                }
                if (Cl > 0)
                {
                    if (WM != "" && WM != null)
                    {
                        commandStringTest = commandStringTest + " test.allandnapr.`Class` = " + Cl + " AND ";
                    }
                    else { commandStringTest = commandStringTest + " test.allandnapr.`Class` = " + Cl + " "; }
                }
                if (WM != "" && WM != null)
                { commandStringTest = commandStringTest + " test.allandnapr.PlatformId = '" + WM + "' "; }
                commandStringTest = commandStringTest + " ORDER BY test.allandnapr.Created DESC;";
            }
        }
        public void ZaprPhotoDop(int NomPR)///int IDTS)
            {
                commandStringTest = "SELECT "
  + "`wd`.`id` AS `id`,"
  + "`wd`.`wim` AS `wim`, "
  + "`wd`.`opposite_direction` AS `opposite_direction`, "
  + "`wd`.`wim_detector_id` AS `wim_detector_id`, "
  + "`wd`.`detection_id` AS `detection_id`, "
  + "`wd`.`detection_image_id` AS `detection_image_id`, "
  + "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
  + "`dd`.`lp_image` AS `lp_image`, "
  + "`ddi`.`image` AS `ObzLob`, "
  + "`si`.`image` AS `Obz`, "
  + "`dd`.`image_id` AS `image_id`, "
  + "`dd`.`lp` AS `lp`, "
  + "`dd`.`detector` AS `detector`, "
  + "`dd`.`vehicle_class` AS `dd_vehicle_class`, "
  + "`dd`.`insert_timestamp` AS `dd_insert_timestamp`, "
  + "`dd`.`ilpc` AS `ilpc`, "
  + "`dd`.`ms` AS `dd_ms`, "
  + "`dd`.`datetime` AS `dd_datetime`, "
  + "`ddi`.`state` AS `state`, "
  + "`ddi`.`state_changed` AS `state_changed`, "
  + "`ddi`.`detection_image_id` AS `ddi_detection_image_id`,"
  + "`ddi`.`parent_image_id` AS `parent_image_id`, "
  + "`ddi`.`insert_timestamp` AS `ddi_insert_timestamp`, "
  + "`si`.`image_id` AS `si_image_id`, "
  + "`si`.`insert_timestamp` AS `si_insert_timestamp`, "
  + "`si`.`image_type` AS `image_type`, "
  + "`si`.`sensor` AS `sensor`, "
  + "`si`.`create_time_ms` AS `create_time_ms`, "
  + "`si`.`create_time` AS `create_time` "
  + "FROM((((`wims_detections` `wd` "
  + "JOIN `detectors_detections` `dd` "
  + "ON((`wd`.`detection_image_id` = `dd`.`image_id`))) "
  + "JOIN `detectors_detections_images` `ddi` "
  + "ON((`wd`.`detection_image_id` = `ddi`.`detection_image_id`))) "
  + "JOIN `sensors_detections_images` `sdi` "
  + "ON ((`wd`.`detection_id` = `sdi`.`detection_id`))) "
  + "JOIN `sensors_images` `si` "
  + "ON ((`sdi`.`image_id` = `si`.`image_id`))) "
  + "WHERE wd.id= " + NomPR + ";";
                }
        public void ZaprPhotoDopLoc(int NomPR)///int IDTS)
        {
            commandStringTest = "SELECT `wd`.`id` AS `id`, "
+ "`wd`.`wim` AS `wim`, "
+ "`wd`.`opposite_direction` AS `opposite_direction`,  "
+ "`wd`.`wim_detector_id` AS `wim_detector_id`, "
+ "`wd`.`detection_id` AS `detection_id`,  "
+ "`wd`.`detection_image_id` AS `detection_image_id`, "
+ "`wd`.`detection_image_id_back` AS `detection_image_id_back`, "
 + "`wd`.`velocity` AS `Скорость`, "
 + "`wd`.`length` AS `Длина ТС`, "
 + "`wd`.`s_height` AS `s_height`, "
  + "`wd`.`s_width` AS `s_width`, "
+ "`dd`.`lp_image` AS `lp_image`,  "
+ "`ddi`.`image` AS `ObzLob`, "
+ "`si`.`image` AS `Obz`, "
+ "`dd`.`image_id` AS `image_id`, "
+ "`dd`.`lp` AS `lp`, "
+ "`dd`.`detector` AS `detector`, "
+ "`dd`.`vehicle_class` AS `dd_vehicle_class`, "
+ "`dd`.`insert_timestamp` AS `dd_insert_timestamp`, "
+ "`dd`.`ilpc` AS `ilpc`, "
+ "`dd`.`ms` AS `dd_ms`, "
+ "`dd`.`datetime` AS `dd_datetime`, "
+ "`ddi`.`state` AS `state`, "
+ "`ddi`.`state_changed` AS `state_changed`, "
+ "`ddi`.`detection_image_id` AS `ddi_detection_image_id`, "
+ "`ddi`.`parent_image_id` AS `parent_image_id`, "
+ "`ddi`.`insert_timestamp` AS `ddi_insert_timestamp`, "
+ "`si`.`image_id` AS `si_image_id`, "
+ "`si`.`insert_timestamp` AS `si_insert_timestamp`, "
+ "`si`.`image_type` AS `image_type`, "
+ "`si`.`sensor` AS `sensor`, "
+ "`si`.`create_time_ms` AS `create_time_ms`, "
+ "`si`.`create_time` AS `create_time` ,"
+ "wd.axles_1_2_base AS axles_1_2_base,"
+ "wd.axles_2_3_base AS axles_2_3_base,"
+ "wd.axles_3_4_base AS axles_3_4_base,"
+ "wd.axles_4_5_base AS axles_4_5_base,"
+ "wd.axles_5_6_base AS axles_5_6_base,"
+ "wd.axles_6_7_base AS axles_6_7_base,"
+ "wd.axles_7_8_base AS axles_7_8_base,"
+ "wd.vehicle_class AS vehicle_class,"
+ "wd.total_weight AS total_weight,"
+ "wd.axles_count AS axles_count , "
  + "IFNULL((`wd`.`axle_1_leftside_load` + `wd`.`axle_1_rightside_load`), 0) AS `o1m`, "
  + "IFNULL((`wd`.`axles_1_2_base` / 100), 0) AS `base1_2`, "
  + "IFNULL(LEFT(`wd`.`dual_tire`, 1), 0) AS `dbl1`, "
  + "IFNULL((`wd`.`axle_2_leftside_load` + `wd`.`axle_2_rightside_load`), 0) AS `o2m`, "
  + "IFNULL((`wd`.`axles_2_3_base` / 100), 0) AS `base2_3`, "
  + "IFNULL(SUBSTR(`wd`.`dual_tire`, 2, 1), 0) AS `dbl2`, "
  + "IFNULL((`wd`.`axle_3_leftside_load` + `wd`.`axle_3_rightside_load`), 0) AS `o3m`, "
  + "IFNULL((`wd`.`axle_4_leftside_load` + `wd`.`axle_4_rightside_load`), 0) AS `o4m`, "
  + "IFNULL((`wd`.`axle_5_leftside_load` + `wd`.`axle_5_rightside_load`), 0) AS `o5m`, "
  + "IFNULL((`wd`.`axle_6_leftside_load` + `wd`.`axle_6_rightside_load`), 0) AS `o6m`, "
  + "IFNULL((`wd`.`axle_7_leftside_load` + `wd`.`axle_7_rightside_load`), 0) AS `o7m`, "
  + "IFNULL((`wd`.`axle_8_leftside_load` + `wd`.`axle_8_rightside_load`), 0) AS `o8m`, "
  + "IFNULL((`wd`.`axle_9_leftside_load` + `wd`.`axle_9_rightside_load`), 0) AS `o9m`, "
  + "IFNULL((`wd`.`axles_3_4_base` / 100), 0) AS `base3_4`, "
  + "IFNULL((`wd`.`axles_4_5_base` / 100), 0) AS `base4_5`, "
  + "IFNULL((`wd`.`axles_5_6_base` / 100), 0) AS `base5_6`, "
  + "IFNULL((`wd`.`axles_6_7_base` / 100), 0) AS `base6_7`, "
  + "IFNULL((`wd`.`axles_7_8_base` / 100), 0) AS `base7_8`, "
  + "IFNULL((`wd`.`axles_8_9_base` / 100), 0) AS `base8_9`, "
  + "SUBSTR(`wd`.`dual_tire`, 3, 1) AS `dbl3`, "
  + "SUBSTR(`wd`.`dual_tire`, 4, 1) AS `dbl4`, "
  + "SUBSTR(`wd`.`dual_tire`, 5, 1) AS `dbl5`, "
  + "SUBSTR(`wd`.`dual_tire`, 6, 1) AS `dbl6`, "
  + "SUBSTR(`wd`.`dual_tire`, 7, 1) AS `dbl7`, "
  + "SUBSTR(`wd`.`dual_tire`, 8, 1) AS `dbl8`, "
  + "SUBSTR(`wd`.`dual_tire`, 9, 1) AS `dbl9` , "
  + "`wd`.`axle_1_leftside_load` AS `axle_1_leftside_load`, "
  + "`wd`.`axle_1_rightside_load` AS `axle_1_rightside_load`, "
  + "`wd`.`axle_2_leftside_load` AS `axle_2_leftside_load`, "
  + "`wd`.`axle_2_rightside_load` AS `axle_2_rightside_load`, "
  + "`wd`.`axle_3_leftside_load` AS `axle_3_leftside_load`, "
  + "`wd`.`axle_3_rightside_load` AS `axle_3_rightside_load`, "
  + "`wd`.`axle_4_leftside_load` AS `axle_4_leftside_load`, "
  + "`wd`.`axle_4_rightside_load` AS `axle_4_rightside_load`, "
  + "`wd`.`axle_5_leftside_load` AS `axle_5_leftside_load`, "
  + "`wd`.`axle_5_rightside_load` AS `axle_5_rightside_load`, "
  + "`wd`.`axle_6_leftside_load` AS `axle_6_leftside_load`, "
  + "`wd`.`axle_6_rightside_load` AS `axle_6_rightside_load`, "
  + "`wd`.`axle_7_leftside_load` AS `axle_7_leftside_load`, "
  + "`wd`.`axle_7_rightside_load` AS `axle_7_rightside_load`, "
  + "`wd`.`axle_8_leftside_load` AS `axle_8_leftside_load`, "
  + "`wd`.`axle_8_rightside_load` AS `axle_8_rightside_load`, "
  + "`wd`.`axle_9_leftside_load` AS `axle_9_leftside_load`, "
  + "`wd`.`axle_9_rightside_load` AS `axle_9_rightside_load` "
+ "FROM((((`camloc`.`wims_detections` `wd` "
+ "JOIN `camloc`.`detectors_detections` `dd` "
+ "ON((`wd`.`detection_image_id` = `dd`.`image_id`))) "
+ "JOIN `camloc`.`detectors_detections_images` `ddi` "
+ "ON((`wd`.`detection_image_id` = `ddi`.`detection_image_id`))) "
+ "JOIN `camloc`.`sensors_detections_images` `sdi` "
+ "ON ((`wd`.`detection_id` = `sdi`.`detection_id`))) "
+ "JOIN `camloc`.`sensors_images` `si` "
+ "ON ((`sdi`.`image_id` = `si`.`image_id`))) "
+ "WHERE wd.id = " + NomPR + ";";
           
        }

        public void ZaprObrabotLoc(int IDTSIsh, int IDTSKon, string NDI, string NDII, string OII, string OIID, string OGRZ, string OKL, string NLP, string NamU, string OlDat, int Ch)
        {
            commandStringTest = "UPDATE wims_det_r "
+ "SET detection_id = '" + NDI + "', "
+ "detection_image_id = '" + NDII + "', "
+ "lp = '" + NLP + "', "
+ "changerec = " + Ch + ", "
+ "OldIdIm = '" + OII + "', "
+ "OldIdImDet = '" + OIID + "', "
+ "NameUs = '" + NamU + "', "
+ "DateChang = DEFAULT, "
+ "OldGRZ = '" + OGRZ + "', "
+ "Prim = 'Связаны два проезда', "
+ "OldKlass ='" + OKL + "', "
+ "OldIDPR ='" + IDTSKon + "', "
+ "OldDate_Loc ='" + OlDat + "', "
+ "SpetsRazr = DEFAULT "
+ "WHERE id = " + IDTSIsh + " ;";
        }

        public void ZaprObrGRZLoc(int IDTSIsh, string OGRZ, string NLP, string NamU, int Ch)
        {
            commandStringTest = "UPDATE vehiclecontainer_r"
+ " SET Plate = '" + NLP + "',"
+ " `Change` = 1,"
+ " ChangeType = " + Ch + ","
+ " DateChang = DEFAULT,"
+ "NameUs = '" + NamU + "', "
+ " OldGRZ = '" + OGRZ + "',"
+ " Prim = 'Изменен ГРЗ' "
+ "WHERE id = " + IDTSIsh + " ;";

//            UPDATE wims_det_r set "
//+ "lp = '" + NLP + "', "
//+ "changerec = " + Ch + ", "
//+ "NameUs = '" + NamU + "', "
//+ "DateChang = DEFAULT, "
//+ "Prim = 'Изменен ГРЗ', "
//+ "OldGRZ = '" + OGRZ + "' "

        }

        public void ZaprAllCamLoc(int IDTS) //для 3 формы
        {
            commandStringTest = "SELECT "
+ "rapraspolojenrubeja.IDWim AS IDWim, "
+ "alcam.id AS id, "
+ "alcam.datetime AS datetime, "
+ "alcam.datepr AS datepr, "
+ "alcam.timepr AS timepr, "
+ "alcam.datetime_local AS datetime_local, "
+ "alcam.ms AS ms, "
+ "alcam.wim AS wim, "
+ "wims_det_r.opposite_direction AS opposite_direction, "
+ "wims_det_r.wim_detector_id AS wim_detector_id, "
+ "wims_det_r.detection_id AS detection_id, "
+ "wims_det_r.detection_image_id AS detection_image_id, "
+ "alcam.detection_image_id_back AS detection_image_id_back, "
+ "alcam.time_distance_front_front AS time_distance_front_front, "
+ "alcam.time_distance_back_front AS time_distance_back_front, "
+ "wims_det_r.vehicle_class AS vehicle_class, "
+ "alcam.velocity AS velocity, "
+ "alcam.length AS length, "
+ "wims_det_r.lp AS lp, "
+ "alcam.lp_back AS lp_back, "
+ "alcam.insert_timestamp AS insert_timestamp, "
+ "alcam.total_weight AS total_weight, "
+ "wims_det_r.axles_count AS axles_count, "
+ "CAST(alcam.axles_1_2_base AS decimal(5, 2)) AS axles_1_2_base, "
+ "CAST(alcam.axles_2_3_base AS decimal(5, 2)) AS axles_2_3_base, "
+ "CAST(alcam.axles_3_4_base AS decimal(5, 2)) AS axles_3_4_base, "
+ "CAST(alcam.axles_4_5_base AS decimal(5, 2)) AS axles_4_5_base, "
+ "CAST(alcam.axles_5_6_base AS decimal(5, 2)) AS axles_5_6_base, "
+ "CAST(alcam.axles_6_7_base AS decimal(5, 2)) AS axles_6_7_base, "
+ "CAST(alcam.axles_7_8_base AS decimal(5, 2)) AS axles_7_8_base, "
+ "CAST(alcam.axles_8_9_base AS decimal(5, 2)) AS axles_8_9_base, "
+ "alcam.axle_1_leftside_load AS axle_1_leftside_load, "
+ "alcam.axle_1_rightside_load AS axle_1_rightside_load, "
+ "alcam.axle_2_leftside_load AS axle_2_leftside_load, "
+ "alcam.axle_2_rightside_load AS axle_2_rightside_load, "
+ "alcam.axle_3_leftside_load AS axle_3_leftside_load, "
+ "alcam.axle_3_rightside_load AS axle_3_rightside_load, "
+ "alcam.axle_4_leftside_load AS axle_4_leftside_load, "
+ "alcam.axle_4_rightside_load AS axle_4_rightside_load, "
+ "alcam.axle_5_leftside_load AS axle_5_leftside_load, "
+ "alcam.axle_5_rightside_load AS axle_5_rightside_load, "
+ "alcam.axle_6_leftside_load AS axle_6_leftside_load, "
+ "alcam.axle_6_rightside_load AS axle_6_rightside_load, "
+ "alcam.axle_7_leftside_load AS axle_7_leftside_load, "
+ "alcam.axle_7_rightside_load AS axle_7_rightside_load, "
+ "alcam.axle_8_leftside_load AS axle_8_leftside_load, "
+ "alcam.axle_8_rightside_load AS axle_8_rightside_load, "
+ "alcam.axle_9_leftside_load AS axle_9_leftside_load, "
+ "alcam.axle_9_rightside_load AS axle_9_rightside_load, "
+ "alcam.overweighting AS overweighting, "
+ "alcam.dual_tire AS dual_tire, "
+ "alcam.validity AS validity, "
+ "CASE WHEN alcam.validity = 0 THEN - 1 ELSE 0 END AS validityInvert, "
+ "alcam.validity_flags AS validity_flags, "
+ "alcam.error_flags AS error_flags, "
+ "alcam.temp_internal AS temp_internal, "
+ "alcam.temp_asphalt AS temp_asphalt, "
+ "alcam.acceleration AS acceleration, "
+ "alcam.overweight_desc AS overweight_desc, "
+ "alcam.car_layout AS car_layout, "
+ "alcam.s_height AS s_height, "
+ "alcam.s_width AS s_width, "
+ "alcam.s_length AS s_length, "
+ "alcam.trailer_presence AS trailer_presence, "
+ "alcam.n1 AS n1, "
+ "alcam.n2 AS n2, "
+ "alcam.n3 AS n3, "
+ "alcam.n4 AS n4, "
+ "alcam.n5 AS n5, "
+ "alcam.n6 AS n6, "
+ "alcam.n7 AS n7, "
+ "alcam.n8 AS n8, "
+ "alcam.n9 AS n9, "
+ "alcam.o1m AS o1m, "
+ "CAST(alcam.base1_2 AS decimal(5, 2)) AS base1_2, "
+ "alcam.dbl1 AS dbl1, "
+ "alcam.o2m AS o2m, "
+ "CAST(alcam.base2_3 AS decimal(5, 2)) AS base2_3, "
+ "alcam.dbl2 AS dbl2, "
+ "alcam.o3m AS o3m, "
+ "alcam.o4m AS o4m, "
+ "alcam.o5m AS o5m, "
+ "alcam.o6m AS o6m, "
+ "alcam.o7m AS o7m, "
+ "alcam.o8m AS o8m, "
+ "alcam.o9m AS o9m, "
+ "CAST(alcam.base3_4 AS decimal(5, 2)) AS base3_4, "
+ "CAST(alcam.base4_5 AS decimal(5, 2)) AS base4_5, "
+ "CAST(alcam.base5_6 AS decimal(5, 2)) AS base5_6, "
+ "CAST(alcam.base6_7 AS decimal(5, 2)) AS base6_7, "
+ "CAST(alcam.base7_8 AS decimal(5, 2)) AS base7_8, "
+ "CAST(alcam.base8_9 AS decimal(5, 2)) AS base8_9, "
+ "alcam.dbl3 AS dbl3, "
+ "alcam.dbl4 AS dbl4, "
+ "alcam.dbl5 AS dbl5, "
+ "alcam.dbl6 AS dbl6, "
+ "alcam.dbl7 AS dbl7, "
+ "alcam.dbl8 AS dbl8, "
+ "alcam.dbl9 AS dbl9, "
+ "alcam.base1_n AS base1_n, "
+ "alcam.lp_image AS lp_image, "
+ "alcam.ObzLob AS ObzLob, "
+ "alcam.Obz AS Obz, "
+ "alcam.image_id AS image_id, "
+ "alcam.expr1 AS expr1, "
+ "alcam.detector AS detector, "
+ "alcam.dd_vehicle_class AS dd_vehicle_class, "
+ "alcam.dd_insert_timestamp AS dd_insert_timestamp, "
+ "alcam.ilpc AS ilpc, "
+ "alcam.dd_ms AS dd_ms, "
+ "alcam.dd_datetime AS dd_datetime, "
+ "alcam.state AS state, "
+ "alcam.state_changed AS state_changed, "
+ "alcam.ddi_detection_image_id AS ddi_detection_image_id, "
+ "alcam.parent_image_id AS parent_image_id, "
+ "alcam.ddi_insert_timestamp AS ddi_insert_timestamp, "
+ "alcam.si_image_id AS si_image_id, "
+ "alcam.si_insert_timestamp AS si_insert_timestamp, "
+ "alcam.image_type AS image_type, "
+ "alcam.sensor AS sensor, "
+ "alcam.create_time_ms AS create_time_ms, "
+ "alcam.create_time AS create_time, "
+ "rapraspolojenrubeja.IDDir AS IDDir, "
+ "rapraspolojenrubeja.primechanie AS primechanie, "
+ "rapraspolojenrubeja.ogranich AS ogranich, "
+ "rapraspolojenrubeja.partad AS partad, "
+ "rapraspolojenrubeja.namead AS namead, "
+ "rapraspolojenrubeja.maxosnagr AS maxosnagr, "
+ "rapraspolojenrubeja.ad_znachen AS ad_znachen, "
+ "rapraspolojenrubeja.dolg AS dolg, "
+ "rapraspolojenrubeja.shir AS shir, "
+ "rapraspolojenrubeja.dislocationapvk AS dislocationapvk, "
+ "rapraspolojenrubeja.sernum AS sernum, "
+ "rapraspolojenrubeja.kodapvk AS kodapvk, "
+ "rapraspolojenrubeja.nameapvk AS nameapvk, "
+ "raptnapr.namenapr AS namenapr, "
+ "raptnapr.npolos AS npolos, "
+ "wims_det_r.id AS expr2, "
+ "wims_det_r.Protc AS Protc, "
+ "wims_det_r.Narush AS Narush, "
+ "wims_det_r.MOsNagrb AS MOsNagrb, "
+ "wims_det_r.MOsNagrm AS MOsNagrm, "
+ "wims_det_r.PolnMb AS PolnMb, "
+ "wims_det_r.PolnMm AS PolnMm, "
+ "wims_det_r.SubKateg AS SubKateg, "
+ "wims_det_r.Kategory AS Kategory, "
+ "wims_det_r.TipSch AS TipSch, "
+ "wims_det_r.NaimKlNew AS NaimKlNew, "
+ "wims_det_r.Npp AS Npp, "
+ "wims_det_r.changerec AS changerec, "
+ "wims_det_r.OldIdIm AS OldIdIm, "
+ "wims_det_r.OldIdImDet AS OldIdImDet, "
+ "wims_det_r.NameUs AS NameUs, "
+ "wims_det_r.DateChang AS DateChang, "
+ "wims_det_r.OldGRZ AS OldGRZ, "
+ "wims_det_r.Prim AS Prim, "
+ "wims_det_r.OldKlass AS OldKlass, "
+ "wims_det_r.SpetsRazr AS SpetsRazr, "
+ "wims_det_r.OldIDPR AS OldIDPR, "
+ "wims_det_r.KlNew AS KlNew, "
+ "wims_det_r.NAKT, "
+ "wims_det_r.NamePDF, "
+ "wims_det_r.NameXML, "
+ "rapraspolojenrubeja.Vladel, "
+ "rapraspolojenrubeja.TipSI, "
+ "rapraspolojenrubeja.Model, "
+ "rapraspolojenrubeja.NomSvidTipaSI, "
+ "rapraspolojenrubeja.DateVidSTSI, "
+ "rapraspolojenrubeja.RegNomSTSI, "
+ "rapraspolojenrubeja.NomSPSI, "
+ "rapraspolojenrubeja.DateVidSPSI, "
+ "rapraspolojenrubeja.SrokSPSI, "
+ "rapraspolojenrubeja.NormPravAktAD, "
+ "rapraspolojenrubeja.Speed, "
+ "rapraspolojenrubeja.CheckPointCode, "
+ "raptssprrazr.KemVid, "
+ "raptssprrazr.PriznNal, "
+ "raptssprrazr.VidPerevoz, "
+ "raptssprrazr.GRZSR, "
+ "raptssprrazr.NomSR, "
+ "raptssprrazr.DateVidSR, "
+ "raptssprrazr.SrokDeistvSR, "
+ "raptssprrazr.RazrMarshr, "
+ " raptssprrazr.RazrMassa, "
+ "raptssprrazr.KolRazrPr, "
+ "raptssprrazr.OsjbUslDvSR, "
+ "raptssprrazr.Os1M, "
+ "raptssprrazr.Os2M, "
+ "raptssprrazr.Os3M, "
+ "raptssprrazr.Os4M, "
+ "raptssprrazr.Os5M, "
+ "raptssprrazr.Os6M, "
+ "raptssprrazr.Os7M, "
+ "raptssprrazr.Os8M, "
+ "raptssprrazr.Os9M, "
+ "raptssprrazr.IspolzPR, "
+ "raptnapr.KodNapr "
+ "FROM wims_det_r "
+ "LEFT OUTER JOIN alcam "
+ "ON wims_det_r.id = alcam.id "
+ "LEFT OUTER JOIN rapraspolojenrubeja "
+ "ON rapraspolojenrubeja.IDWim = alcam.wim "
+ "LEFT OUTER JOIN raptnapr "
+ " ON rapraspolojenrubeja.IDWim = raptnapr.KodNapr "
+ "LEFT OUTER JOIN raptssprrazr "
+ "  ON wims_det_r.id = raptssprrazr.idts "
+ " WHERE `test`.`alcam`.`id` = " + IDTS + ";";
        }

        public void ZaprAllCamNaprL(int IDTS)//для 2 и 3 формы
        {
            if (IDTS == 0)
            {
                commandStringTest = "SELECT * "
                                    + "FROM test.allandnapr; ";
                //commandStringTest = "SELECT * "
                //                    + "FROM test.allandnapr; ";
            }
            else
            {

                commandStringTest = "SELECT"
    + " allandnapr.* "
    + "FROM test.allandnapr "
    + " WHERE allandnapr.ID = " + IDTS + "; ";
                //            commandStringTest = "SELECT"
                //+ " allandnapr.* "
                //+ "FROM test.allandnapr "
                //+ " WHERE allandnapr.id = " + IDTS + "; ";
            }
        }

        public void ZaprAllCamNaprLO(int IDTS)//для 2 и 3 формы
        {
            if (IDTS == 0)
            {
                commandStringTest = "SELECT * "
                                    + "FROM test.allandnaprandaxel; ";
                //commandStringTest = "SELECT * "
                //                    + "FROM test.allandnapr; ";
            }
            else
            {

                commandStringTest = "SELECT"
    + " allandnaprandaxel.* "
    + "FROM test.allandnaprandaxel "
    + " WHERE allandnaprandaxel.ID = " + IDTS + "; ";
                //            commandStringTest = "SELECT"
                //+ " allandnapr.* "
                //+ "FROM test.allandnapr "
                //+ " WHERE allandnapr.id = " + IDTS + "; ";
            }
        }

        public void ZaprBitmap(Int64 IDTS)//для 2 и 3 формы
        {
            if (IDTS == 0)
            {
                commandStringTest = "SELECT * "
                                    + "FROM test.binarycontainer; ";
                //commandStringTest = "SELECT * "
                //                    + "FROM test.allandnapr; ";
            }
            else
            {

                commandStringTest = "SELECT "
                                    + " binarycontainer.*, "
                                    + "binarycontainer.ID_PR "
                                    + "FROM binarycontainer "
                                    + "WHERE binarycontainer.ID_PR = " + IDTS + "; ";

            }
        }


        public void ZapolnenNarushen()
        {
            commandStringTest = " INSERT INTO test.wims_det_r(id, "
  + "datetime,"
  + "datepr,"
  + "timepr,"
  + "datetime_local,"
  + "ms,"
  + "wim,"
  + "opposite_direction,"
  + "wim_detector_id,"
  + "detection_id,"
  + "detection_image_id,"
  + "detection_image_id_back,"
  + "time_distance_front_front,"
  + "time_distance_back_front,"
  + "vehicle_class,"
  + "velocity,"
  + "length,"
  + "lp,"
  + "lp_back,"
  + "insert_timestamp,"
  + "total_weight,"
  + "axles_count,"
  + "axles_1_2_base,"
  + "axles_2_3_base,"
  + "axles_3_4_base,"
  + "axles_4_5_base,"
  + "axles_5_6_base,"
  + "axles_6_7_base,"
  + "axles_7_8_base,"
  + "axles_8_9_base,"
  + "axle_1_leftside_load,"
  + "axle_1_rightside_load,"
  + "axle_2_leftside_load,"
  + "axle_2_rightside_load,"
  + "axle_3_leftside_load,"
  + "axle_3_rightside_load,"
  + "axle_4_leftside_load,"
  + "axle_4_rightside_load,"
  + "axle_5_leftside_load,"
  + "axle_5_rightside_load,"
  + "axle_6_leftside_load,"
  + "axle_6_rightside_load,"
  + "axle_7_leftside_load,"
  + "axle_7_rightside_load,"
  + "axle_8_leftside_load,"
  + "axle_8_rightside_load,"
  + "axle_9_leftside_load,"
  + "axle_9_rightside_load,"
  + "overweighting,"
  + "dual_tire,"
  + "validity,"
  + "validity_flags,"
  + "error_flags,"
  + "temp_internal,"
  + "temp_asphalt,"
  + "acceleration,"
  + "overweight_desc,"
  + " car_layout,"
  + " s_height,"
  + " s_width,"
  + " s_length,"
  + " trailer_presence,"
  + " o1m,"
  + " o2m,"
  + " o3m,"
  + " o4m,"
  + " o5m,"
  + " o6m,"
  + " o7m,"
  + " o8m,"
  + " o9m,"
  + " dbl1,"
  + " dbl2,"
  + " dbl3,"
  + " dbl4,"
  + " dbl5,"
  + " dbl6,"
  + " dbl7,"
  + " dbl8,"
  + " dbl9)"
  + " SELECT"
  + "   wims_detections.id,"
  + "   wims_detections.datetime,"
  + " CAST(wims_detections.datetime_local AS date) AS datepr,"
  + " CAST(wims_detections.datetime_local AS time) AS timepr,"
  + " wims_detections.datetime_local,"
  + " wims_detections.ms,"
  + " wims_detections.wim,"
  + " wims_detections.opposite_direction,"
  + " wims_detections.wim_detector_id,"
  + " wims_detections.detection_id,"
  + " wims_detections.detection_image_id,"
  + " wims_detections.detection_image_id_back,"
  + " wims_detections.time_distance_front_front,"
  + " wims_detections.time_distance_back_front,"
  + " wims_detections.vehicle_class,"
  + " wims_detections.velocity,"
  + " wims_detections.length,"
  + " wims_detections.lp,"
  + " wims_detections.lp_back,"
  + " wims_detections.insert_timestamp,"
  + "    wims_detections.total_weight,"
  + "    wims_detections.axles_count,"
  + "    wims_detections.axles_1_2_base,"
  + "    wims_detections.axles_2_3_base,"
  + "    wims_detections.axles_3_4_base,"
  + "    wims_detections.axles_4_5_base,"
  + "    wims_detections.axles_5_6_base,"
  + "    wims_detections.axles_6_7_base,"
  + "    wims_detections.axles_7_8_base,"
  + "    wims_detections.axles_8_9_base,"
  + "    wims_detections.axle_1_leftside_load,"
  + "    wims_detections.axle_1_rightside_load,"
  + "    wims_detections.axle_2_leftside_load,"
  + "    wims_detections.axle_2_rightside_load,"
  + "    wims_detections.axle_3_leftside_load,"
  + "    wims_detections.axle_3_rightside_load,"
  + "    wims_detections.axle_4_leftside_load,"
  + "    wims_detections.axle_4_rightside_load,"
  + "    wims_detections.axle_5_leftside_load,"
  + "    wims_detections.axle_5_rightside_load,"
  + "    wims_detections.axle_6_leftside_load,"
  + "    wims_detections.axle_6_rightside_load,"
  + "    wims_detections.axle_7_leftside_load,"
  + "    wims_detections.axle_7_rightside_load,"
  + "    wims_detections.axle_8_leftside_load,"
  + "    wims_detections.axle_8_rightside_load,"
  + "    wims_detections.axle_9_leftside_load,"
  + "    wims_detections.axle_9_rightside_load,"
  + "    wims_detections.overweighting,"
  + "    wims_detections.dual_tire,"
  + "    wims_detections.validity,"
  + "    wims_detections.validity_flags,"
  + "    wims_detections.error_flags,"
  + "    wims_detections.temp_internal,"
  + "    wims_detections.temp_asphalt,"
  + "    wims_detections.acceleration,"
  + "    wims_detections.overweight_desc,"
  + "    wims_detections.car_layout,"
  + "    wims_detections.s_height,"
  + "    wims_detections.s_width,"
  + "    wims_detections.s_length,"
  + "    wims_detections.trailer_presence,"
  + "  IFNULL((wims_detections.axle_1_leftside_load + wims_detections.axle_1_rightside_load), 0) AS o1m,"
  + "  IFNULL((wims_detections.axle_2_leftside_load + wims_detections.axle_2_rightside_load), 0) AS o2m,"
  + "  IFNULL((wims_detections.axle_3_leftside_load + wims_detections.axle_3_rightside_load), 0) AS o3m,"
  + "  IFNULL((wims_detections.axle_4_leftside_load + wims_detections.axle_4_rightside_load), 0) AS o4m,"
  + "  IFNULL((wims_detections.axle_5_leftside_load + wims_detections.axle_5_rightside_load), 0) AS o5m,"
  + "  IFNULL((wims_detections.axle_6_leftside_load + wims_detections.axle_6_rightside_load), 0) AS o6m,"
  + "  IFNULL((wims_detections.axle_7_leftside_load + wims_detections.axle_7_rightside_load), 0) AS o7m,"
  + "  IFNULL((wims_detections.axle_8_leftside_load + wims_detections.axle_8_rightside_load), 0) AS o8m,"
  + "  IFNULL((wims_detections.axle_9_leftside_load + wims_detections.axle_9_rightside_load), 0) AS o9m,"
  + "  IFNULL(LEFT(wims_detections.dual_tire, 1), 0) AS dbl1,"
  + "  IFNULL(SUBSTR(wims_detections.dual_tire, 2, 1), 0) AS dbl2,"
  + "  SUBSTR(wims_detections.dual_tire, 3, 1) AS dbl3,"
  + "  SUBSTR(wims_detections.dual_tire, 4, 1) AS dbl4,"
  + "  SUBSTR(wims_detections.dual_tire, 5, 1) AS dbl5,"
  + "  SUBSTR(wims_detections.dual_tire, 6, 1) AS dbl6,"
  + "  SUBSTR(wims_detections.dual_tire, 7, 1) AS dbl7,"
  + "  SUBSTR(wims_detections.dual_tire, 8, 1) AS dbl8,"
  + "  SUBSTR(wims_detections.dual_tire, 9, 1) AS dbl9"
  + "  FROM camloc.wims_detections"
  + "    LEFT OUTER JOIN test.vmaxmydet"
  + "      ON wims_detections.id > vmaxmydet.MID"
  + "  WHERE wims_detections.axles_count > 2"
  + "  AND wims_detections.total_weight > 4000"
  + "  AND(wims_detections.validity > 0"
  + "  OR wims_detections.error_flags > 0"
  + "  OR wims_detections.lp LIKE 'UNKNOWN_E')"
  + "  OR wims_detections.overweighting > 0"
  + "  LIMIT 2;";

        }

        //// Запрос ПД осевой нагрузки (для каждой оси)
        public void PDOsNagr(int DO, int TypeO, double ADNagr, double RasstOs)
        {
            commandStringTest = "SELECT"
  + "  raposnagrts.iddon,"
  + "  raposnagrts.duble_os,"
  + "  raposnagrts.tupeos,"
  + "  raposnagrts.nametupeos,"
  + "  raposnagrts.rasstjsey_min,"
  + "  raposnagrts.rasstjsey_max,"
  + "  raposnagrts.pdo,"
  + "  raposnagrts.pdt,"
  + "  raposnagrts.nagrad"
  + "  FROM raposnagrts"
  + "  WHERE raposnagrts.duble_os = " + DO + ""
  + "  AND raposnagrts.tupeos = " + TypeO + ""
  + "  AND raposnagrts.rasstjsey_min <= " + RasstOs + ""
  + "  AND raposnagrts.nagrad = " + ADNagr + ""
  + "  AND raposnagrts.rasstjsey_max >= " + RasstOs + " ;";
        }
        //// Запрос ПД общей массы
        public void PDObshMass(int KolOs, int TTS)
        {
            commandStringTest = "SELECT"
  + "  rapdopmassts.iddmts,"
  + "  rapdopmassts.typets,"
  + "  rapdopmassts.kolos,"
  + "  rapdopmassts.pdmassts"
  + "  FROM rapdopmassts"
  + "  WHERE rapdopmassts.kolos = " + KolOs + ""
  + "  AND rapdopmassts.typets = " + TTS + " ;";
        }

        public void AD(int ID)
        {
            if (ID == 0)
            {
                commandStringTest = "SELECT"
      + "  rapdoroga.*"
      + "  FROM rapdoroga ;";
            }
            else
            {
                commandStringTest = "SELECT"
                      + "  rapdoroga.*"
                      + "  FROM rapdoroga"
  + "  WHERE rapdoroga.id = " + ID + "; ";
            }
        }
        public void MDAD(int ID)
        {
            if (ID == 0)
            {
                commandStringTest = "SELECT"
      + "  rapmestodislokatsii.*"
      + "  FROM rapmestodislokatsii ;";
            }
            else
            {
                commandStringTest = "SELECT"
                      + "  rapmestodislokatsii.*"
                      + "  FROM rapmestodislokatsii"
  + "  WHERE rapmestodislokatsii.id = " + ID + "; ";
            }
        }
        //// Запрос Класса ТС
        public void KlassTS(double [] D111 ,double D1_2, double D2_3, double D3_4, double D4_5, double D5_6, double D6_7, double D7_8, int KolOs, double ObshMass)
        {
            commandStringTest = "SELECT"
  + "  raptklassts.idklassts,"
  + "  raptklassts.Klass,"
  + "  raptklassts.naimklassts,"
  + "  raptklassts.tipschema,"
  + "  raptklassts.ColOsey,"
  + "  raptklassts.Distanc1_2Min,"
  + "  raptklassts.Distanc1_2Max,"
  + "  raptklassts.Distanc2_3Min,"
  + "  raptklassts.Distanc2_3Max,"
  + "  raptklassts.Distanc3_4Min,"
  + "  raptklassts.Distanc3_4Max,"
  + "  raptklassts.Distanc4_5Min,"
  + "  raptklassts.Distanc4_5Max,"
  + "  raptklassts.Distanc5_6Min,"
  + "  raptklassts.Distanc5_6Max,"
  + "  raptklassts.Distanc6_7Min,"
  + "  raptklassts.Distanc6_7Max,"
  + "  raptklassts.Distanc7_8Min,"
  + "  raptklassts.Distanc7_8Max,"
  + "  raptklassts.Kategory,"
  + "  raptklassts.PolnMassb,"
  + "  raptklassts.SubCategory,"
  + "  raptklassts.PolnMassm,"
  + "  raptklassts.prim"
  + "  FROM raptklassts"
  + "  WHERE raptklassts.Distanc1_2Min<= " + D111[1]*100 + ""
  + "  AND raptklassts.Distanc1_2Max>= " + D111[1] * 100 + "";
            if(ObshMass<=4999)
            {
                commandStringTest = commandStringTest + "  AND raptklassts.PolnMassb = 4999" ;
            }
            else
            {
                commandStringTest = commandStringTest + "  AND raptklassts.PolnMassb > 4999";
            }
            if (KolOs > 0 && KolOs <7)
            {
                commandStringTest = commandStringTest + " AND raptklassts.ColOsey = " + KolOs + "";
            }
           
            for (int i = 2; i<=KolOs; i++)
            {
                if (D111[i]>0)
                {
                    commandStringTest = commandStringTest + "  AND raptklassts.Distanc" + i + "_" + (i+1) + "Min<= " + D111[i] * 100 + " AND raptklassts.Distanc" + i + "_" + (i + 1) + "Max>= " + D111[i] * 100 + "";
                }
                else if(D111[i] == 0)
                {
                    commandStringTest = commandStringTest + " ;";
                    break;
                }
            }
  
  //+ "  AND raptklassts.Distanc2_3Min<= " + D2_3 + ""
  //+ "  AND raptklassts.Distanc2_3Max>= " + D2_3 + ""
  //+ "  AND raptklassts.Distanc3_4Min<= " + D3_4 + ""
  //+ "  AND raptklassts.Distanc3_4Max>= " + D3_4 + ""
  //+ "  AND raptklassts.Distanc4_5Min<= " + D4_5 + ""
  //+ "  AND raptklassts.Distanc4_5Max>= " + D4_5 + ""
  //+ "  AND raptklassts.Distanc5_6Min<= " + D5_6 + ""
  //+ "  AND raptklassts.Distanc5_6Max>= " + D5_6 + ""
  //+ "  AND raptklassts.Distanc6_7Min<= " + D6_7 + ""
  //+ "  AND raptklassts.Distanc6_7Max>= " + D6_7 + ""
  //+ "  AND raptklassts.Distanc7_8Min<= " + D7_8 + ""
  //+ "  AND raptklassts.Distanc7_8Max>= " + D7_8 + " ;";
        }

        public void MaxAktNum()
        {
            commandStringTest = "SELECT"
  + " MAX(wims_det_r.NAKT) AS MNA"
  + " FROM wims_det_r ;";
        }
        public void COMBOKOMPL()
        {
            commandStringTest = "SELECT"
  + " kodapvk as KAPVGK, nameapvk"
  + " FROM rapraspolojenrubeja"
  + " GROUP BY nameapvk;";
        }

        public void RDLYAIZMENENIYA(int IDp)
        {
            commandStringTest = "SELECT"
   + " allandnaprandaxel.* "
   + "FROM test.allandnaprandaxel ";
    
            if (IDp > 0)
            {
                commandStringTest = commandStringTest + " WHERE allandnaprandaxel.ID = " + IDp + "; ";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
        public void KartUser(int IDp)
        {
            commandStringTest = "SELECT"
  + " raptuser.*"
  + " FROM raptuser";
            if (IDp > 0)
            {
                commandStringTest = commandStringTest + " WHERE iduser = " + IDp + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
        public void ZaprUs(string N1, string N2)
        {
            commandStringTest = "SELECT"
  + " raptuser.*"
  + " FROM raptuser";
            if ((N1 !="") &&(N2!=""))
            {
                commandStringTest = commandStringTest + " WHERE user = '" + N1 + "' AND passuser = '" + N2 + "';";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }

        public void SPRAVOCHNKPDKO(int IDk)
        {
            commandStringTest = "SELECT"
  + " raposnagrts.*"
  + " FROM raposnagrts";
            if (IDk > 0)
            {
                commandStringTest = commandStringTest + " WHERE iddon = " + IDk + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
        public void SPRAVOCHNPDK(int IDk)
        {
            commandStringTest = "SELECT"
  + " rapdopmassts.*"
  + " FROM rapdopmassts";
            if (IDk > 0)
            {
                commandStringTest = commandStringTest + " WHERE iddmts = " + IDk + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
        public void SPRAVOCHNKlass(int IDk)
        {
            commandStringTest = "SELECT"
  + " raptklassts.*"
  + " FROM raptklassts";
            if (IDk > 0)
            {
                commandStringTest = commandStringTest + " WHERE idklassts = " + IDk + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
        public void SPRAVOCHNRubej(int IDr)
        {
            commandStringTest = "SELECT"
  + " rapraspolojenrubeja.*"
  + " FROM rapraspolojenrubeja";
            if (IDr > 0)
            {
                commandStringTest = commandStringTest + " WHERE idrub = " + IDr + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }
       
public void SPRAVOCHNNAPR(int IDr)
        {
            commandStringTest = "SELECT"
  + " raptnapr.*"
  + " FROM raptnapr";
            if (IDr > 0)
            {
                commandStringTest = commandStringTest + " WHERE IDKOMPL = " + IDr + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }

        public void SPETSRAZRESHEN(int IDr)
        {
            commandStringTest = "SELECT"
  + " raptssprrazr.*"
  + " FROM raptssprrazr";
            if (IDr > 0)
            {
                commandStringTest = commandStringTest + " WHERE IdPor = " + IDr + ";";
            }
            else
            {
                commandStringTest = commandStringTest + ";";
            }
        }

    }

          
    }
//}
