using System;
using System.IO;

namespace file_demo
{
    public class DriveUtil
    {
        
        //AvailableFreeSpace	只读属性，获取驱动器上的可用空闲空间量 (以字节为单位)
        // DriveFormat	只读属性，获取文件系统格式的名称，例如 NTFS 或 FAT32
        // DriveType	只读属性，获取驱动器的类型，例如 CD-ROM、可移动驱动器、网络驱动器或固定驱动器
        // IsReady	只读属性，获取一个指示驱动器是否已准备好的值，True 为准备好了， False 为未准备好
        // Name	只读属性，获取驱动器的名称，例如 C:\
        // RootDirectory	只读属性，获取驱动器的根目录
        // TotalFreeSpace	只读属性，获取驱动器上的可用空闲空间总量 (以字节为单位)
        // TotalSize	只读属性，获取驱动器上存储空间的总大小 (以字节为单位)
        // VolumeLabel	属性， 获取或设置驱动器的卷标
        // Driveinfo[] GetDrives()	静态方法，检索计算机上所有逻辑驱动器的驱动器名称
        public static void ShowDriveInfo(string driveName)
        {
            var drive = new DriveInfo(driveName);
            Console.WriteLine("驱动器的名称：" + drive.Name);
            Console.WriteLine("驱动器类型：" + drive.DriveType);
            Console.WriteLine("驱动器的文件格式：" + drive.DriveFormat);
            Console.WriteLine("驱动器中可用空间大小(byte)：" + drive.TotalFreeSpace);
            Console.WriteLine("驱动器总大小(byte)：" + drive.TotalSize);
        }
    }
}