package cipher;

public class object implements Comparable<object> {
	private int id;
	private int tong;
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getTong() {
		return tong;
	}
	public void setTong(int tong) {
		this.tong = tong;
	}
	
	@Override
	public int compareTo(object obj) {
        // sort student's name by ASC
        return obj.getTong() - this.getTong();
    }
}
