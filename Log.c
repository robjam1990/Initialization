#include <stdio.h>
#include <stdint.h>
#include <string.h>

void Log(int num);
void Encyclopedia(const char* text);

int main() {
    // Pointer to the start of the Log function
    unsigned char* logFunc = (unsigned char*)Log;

    // Calculate the relative address from Log to Encyclopedia
    uintptr_t logAddr = (uintptr_t)Log;
    uintptr_t encAddr = (uintptr_t)Encyclopedia;
    int32_t relativeAddr = (int32_t)(encAddr - logAddr - 5);

    // Modify the Log function to call the Encyclopedia function
    logFunc[0] = 0xE8; // Call opcode

    // Split the relative address into bytes and store in the Log function
    memcpy(logFunc + 1, &relativeAddr, sizeof(relativeAddr));

    // Flush instruction cache to ensure modifications take effect
    __builtin___clear_cache((char*)logFunc, (char*)logFunc + 5);

    // Call the Log function
    Log(42);

    return 0;
}

void Log(int num) {
    printf("Logging: %d\n", num);
}

void Encyclopedia(const char* text) {
    printf("Encyclopedia: %s\n", text);
}
