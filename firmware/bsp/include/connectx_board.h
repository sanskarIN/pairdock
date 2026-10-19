#ifndef SCX_CONNECTX_BOARD_H
#define SCX_CONNECTX_BOARD_H

#include "scx_error.h"

#ifdef __cplusplus
extern "C" {
#endif

scx_error_t scx_board_init(void);
const char *scx_board_name(void);

#ifdef __cplusplus
}
#endif

#endif
