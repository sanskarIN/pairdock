/* PairDock interrupt vector example. */

.section .vectors
.global scx_interrupt_vectors

scx_interrupt_vectors:
  .word scx_reset_handler
  .word scx_default_isr
  .word scx_default_isr
  .word scx_default_isr

.section .text
.global scx_default_isr
scx_default_isr:
  /* SCX-TODO: Capture interrupt source and forward to diagnostics. */
  ret
