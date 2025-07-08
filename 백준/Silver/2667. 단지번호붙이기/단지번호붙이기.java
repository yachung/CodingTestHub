import java.io.*;
import java.util.*;

public class Main {

    public static class Point {
        int x;
        int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    public static int[][] directions = {{1, 0}, {0, 1}, {-1, 0}, {0, -1}};
    public static boolean[][] visited;
    public static int count = 0;

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int N = Integer.parseInt(br.readLine());
        int[][] map = new int[N][N];
        visited = new boolean[N][N];

        for (int i = 0; i < N; i++) {
            String input = br.readLine();
            for (int j = 0; j < N; j++) {
                map[i][j] = input.charAt(j) - '0';
            }
        }

        List<Integer> counts = new ArrayList<>();

        for (int i = 0; i < N; i++) {
            for (int j = 0; j < N; j++) {
                if (visited[i][j] || map[i][j] == 0) continue;

                count = 0;
                count = dfs(i, j, map);
                counts.add(count);
            }
        }

        counts.sort(Comparator.naturalOrder());
        sb.append(counts.size()).append("\n");
        for (var count : counts) {
            sb.append(count).append("\n");
        }
        System.out.println(sb);
    }

    public static int dfs(int x, int y, int[][] map) {

        Point current = new Point(x, y);

        visited[current.x][current.y] = true;
        count += 1;

        for (var dir : directions) {
            int dx = current.x + dir[0];
            int dy = current.y + dir[1];

            if (dx >= map.length || dy >= map.length || dx < 0 || dy < 0) continue;
            if (map[dx][dy] == 0) continue;
            if (visited[dx][dy]) continue;

            dfs(dx, dy, map);
        }
        return count;
    }
}