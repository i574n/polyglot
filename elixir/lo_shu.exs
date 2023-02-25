defmodule LoShu do
  def valid_square?(square) do
    sums = square |> Enum.map(&sum/1)
    sums = sums |> Enum.uniq
    sums = sums |> Enum.count
    sums == 1
  end

  def sum(list) do
    list |> Enum.reduce(0, &+/2)
  end
end

square = [[4, 9, 2], [3, 5, 7], [8, 1, 6]]

IO.puts LoShu.valid_square?(square)
