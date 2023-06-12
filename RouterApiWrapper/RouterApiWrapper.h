#pragma once

#include "RouterApi.hpp"

#include <msclr/marshal_cppstd.h>

using namespace System;

namespace RouterApiWrapper {
	public ref class RouterApiWrapperClass
	{
	public:
		int AddRouter(System::String^ ip) {

			std::string ipStr = msclr::interop::marshal_as<std::string>(ip);
			int result;

			result = Vapi::AddRouter(ipStr);
			return result;
		}
	};
}
