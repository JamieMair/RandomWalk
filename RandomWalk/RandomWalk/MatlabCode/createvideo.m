path = input('Enter the path of the folder: ', 's');
filename = 'Movie';
compression = 'Uncompressed Avi';
filetype = '.bmp';
%'Uncompressed AVI'
writerObj = VideoWriter([path '/' filename '.avi']);
writerObj.FrameRate = input('Frame rate?: ');
open(writerObj);
maxFrame = input('How many frames are there?: ');
for i=1:maxFrame
   A = imread([path '/' num2str(i) filetype]); 
   writeVideo(writerObj ,A);
end

close(writerObj);
