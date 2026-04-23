using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    // =======================================================
    // 1. HOME CONTROLLER (Quản lý các trang chính)
    // =======================================================
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SanPham()
        {
            return View();
        }

        public IActionResult LienHe()
        {
            return View();
        }

        public IActionResult HangMoiVe()
        {
            return View();
        }

        public IActionResult HangKhuyenMai()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    // =======================================================
    // 2. ACCOUNT CONTROLLER (Quản lý Đăng nhập / Đăng ký)
    // =======================================================
    public class AccountController : Controller
    {
        // Hiển thị trang Đăng Nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Xử lý khi người dùng bấm nút Đăng Nhập
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Code Demo: Tài khoản mặc định là admin / 123456
            if (username == "admin" && password == "123456")
            {
                TempData["Success"] = "Xác thực thành công. Xin chào Đặc Vụ!";
                return RedirectToAction("Index", "Home");
            }
            
            ViewBag.Error = "Cảnh báo: Sai mã định danh hoặc mật khẩu!";
            return View();
        }

        // Hiển thị trang Đăng Ký
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Xử lý khi người dùng bấm Đăng Ký
        [HttpPost]
        public IActionResult Register(string username, string email, string password)
        {
            // Code Demo: Cứ bấm là thành công
            TempData["Success"] = "Gia nhập mạng lưới thành công! Hãy đăng nhập.";
            return RedirectToAction("Login");
        }
    }
}