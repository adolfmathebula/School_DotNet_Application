using System.Net.Http.Json;
using SchoolClient.Models;


namespace SchoolClient.Services
{
    public class CoursesService
    {
        private readonly HttpClient _http;
        public CoursesService(HttpClient http) => _http = http;

        public async Task<List<Course>> GetCourses() =>
            await _http.GetFromJsonAsync<List<Course>>("api/courses");
    }
}