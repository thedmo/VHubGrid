$url = "https://github.com/thedmo/VideoHub-Simulator/releases/download/v1.0.1/debug.zip"
$outputFile = "VideohubSimulator_v1.0.1_debug.zip"


    Invoke-WebRequest -Uri $url -OutFile $outputFile


