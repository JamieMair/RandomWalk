function createmoviefrombmp(path, filename, compression, filetype, framerate, totalframes)
%'Uncompressed AVI'
writerObj = VideoWriter([path '/' filename '.avi'], compression);
writerObj.FrameRate = framerate;
open(writerObj);
for i=1:totalframes
   A = imread([path '/' num2str(i) filetype]); 
   writeVideo(writerObj ,A);
end

close(writerObj);
end