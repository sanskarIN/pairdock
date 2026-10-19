#include "connectx_board.h"
#include "board_pins.h"
#include "scx_hal_adc.h"
#include "scx_hal_gpio.h"
#include "scx_hal_pwm.h"
#include "scx_hal_uart.h"

scx_error_t scx_board_init(void) {
  scx_error_t status = scx_hal_gpio_configure(SCX_PIN_STATUS_LED, SCX_GPIO_OUTPUT);
  if (status != SCX_OK) {
    return status;
  }

  status = scx_hal_gpio_configure(SCX_PIN_FACTORY_BUTTON, SCX_GPIO_INPUT);
  if (status != SCX_OK) {
    return status;
  }

  status = scx_hal_uart_init(SCX_UART_DEBUG_PORT, 115200);
  if (status != SCX_OK) {
    return status;
  }

  status = scx_hal_adc_init(SCX_PIN_SENSOR_ADC);
  if (status != SCX_OK) {
    return status;
  }

  return scx_hal_pwm_init(SCX_PWM_LED_CHANNEL, 1000);
}

const char *scx_board_name(void) {
  return "SanskarConnectX-DevKit";
}

