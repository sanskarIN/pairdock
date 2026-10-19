/* Context switch example for documentation and future RTOS integration. */

.section .text.context
.global scx_context_switch_example

scx_context_switch_example:
  /* SCX-TODO: Save registers, switch stack, restore registers. */
  ret

