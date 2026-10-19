#include "scx_hal_timer.h"

static uint64_t s_fake_millis = 0;

uint64_t scx_hal_timer_millis(void) {
  return s_fake_millis;
}

void scx_hal_timer_delay_ms(uint32_t delay_ms) {
  s_fake_millis += delay_ms;
}
