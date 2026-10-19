/* PairDock startup example.
 * This file is illustrative and must be adapted to the selected ESP32 target.
 * Made by Sanskar.
 */

.section .text.startup
.global scx_reset_handler

scx_reset_handler:
  /* SCX-TODO: Set stack pointer, initialize memory, and jump to app entry. */
  ret
