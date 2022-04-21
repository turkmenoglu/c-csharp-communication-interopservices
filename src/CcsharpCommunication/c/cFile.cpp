#include <stdio.h>
#include "cFile.h"

extern "C"
{
	__declspec(dllexport) void hi()
	{

		printf("it works...\n");

	}
}