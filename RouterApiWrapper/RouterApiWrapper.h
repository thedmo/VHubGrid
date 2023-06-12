#pragma once

#include "RouterApi.hpp"

using namespace System;

namespace RouterApiWrapper {
	public ref class RouterApiWrapperClass
	{
	public:
		void AddRouter() {
			std::string ipStr = "127.0.0.1";

			Vapi::AddRouter(ipStr);

		}
	};
}
